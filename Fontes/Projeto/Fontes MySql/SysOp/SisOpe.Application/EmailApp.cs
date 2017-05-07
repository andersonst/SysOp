using SisOpe.Application.Interfaces;
using SisOpe.Domain.Entidades;
using SisOpe.Application.Interfaces;
using SisOpe.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Application
{
    public class EmailApp : AppServiceBase<Email>, IEmailAppService
    {
        private readonly IEmailService _emailService;

        public EmailApp(IEmailService emailService)
            : base(emailService)
        {
            _emailService = emailService;
        }
    }
}
