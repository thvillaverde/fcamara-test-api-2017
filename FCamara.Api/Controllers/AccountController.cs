using FCamara.Domain.Contracts;
using FCamara.Domain.Entities;
using FCamara.Infra.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FCamara.Api.Controllers
{

    public class AccountController : ApiController
    {
        UserRepository _repository;

        public AccountController()
        {
            _repository = new UserRepository();
        }


        protected override void Dispose(bool disposing)
        {
            _repository.Dispose();
        }
    }
}
