using SisOpe.Application.Interfaces;
using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Services;

namespace SisOpe.Application
{
    public class EmailAppService : AppServiceBase<Email>, IEmailAppService
    {
        private readonly IEmailService _emailService;

        public EmailAppService(IEmailService emailService)
            : base(emailService)
        {
            _emailService = emailService;
        }
    }
}
