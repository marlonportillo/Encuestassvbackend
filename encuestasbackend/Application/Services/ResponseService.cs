using encuestasbackend.Application.DTOs;
using encuestasbackend.Application.Interfaces;
using encuestasbackend.Domain.Entities;
using encuestasbackend.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace encuestasbackend.Application.Services
{
    public class ResponseService : IResponseService
    {
        private readonly AplicationDbContext _context;

        public ResponseService(AplicationDbContext context)
        {
            _context = context;
        }

        // Crear una nueva respuesta
        public async Task<Guid> SubmitResponseAsync(CreateResponseDto dto)
        {
            // Crear la respuesta
            var response = new Response
            {
                ResponseId = Guid.NewGuid(),
                ParticipantId = dto.ParticipantId,
                QuestionId = dto.QuestionId,
                ResponseText = dto.ResponseText,
                CreatedAt = DateTime.UtcNow
            };

            // Agregar las opciones seleccionadas, si las hay
            if (dto.SelectedOptionIds != null && dto.SelectedOptionIds.Any())
            {
                var responseOptions = dto.SelectedOptionIds.Select(optionId => new ResponseOption
                {
                    OptionId = optionId,
                    ResponseId = response.ResponseId
                }).ToList();

                response.ResponseOptions = responseOptions;
            }

            _context.Responses.Add(response);
            await _context.SaveChangesAsync();

            return response.ResponseId;
        }

        // Obtener las respuestas por ID de pregunta
        public async Task<IEnumerable<ResponseDto>> GetByQuestionIdAsync(Guid questionId)
        {
            var responses = await _context.Responses
                .Where(r => r.QuestionId == questionId)
                .Include(r => r.ResponseOptions)
                .ToListAsync();

            return responses.Select(r => new ResponseDto
            {
                ResponseId = r.ResponseId,
                ResponseText = r.ResponseText,
                CreatedAt = r.CreatedAt
            });
        }

        // Obtener las respuestas por ID de participante
        public async Task<IEnumerable<ResponseDto>> GetByParticipantIdAsync(Guid participantId)
        {
            var responses = await _context.Responses
                .Where(r => r.ParticipantId == participantId)
                .Include(r => r.ResponseOptions)
                .ToListAsync();

            return responses.Select(r => new ResponseDto
            {
                ResponseId = r.ResponseId,
                ResponseText = r.ResponseText,
                CreatedAt = r.CreatedAt
            });
        }
    }
}
