using SisOpe.Application.Interfaces;
using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Repositories;
using SisOpe.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
