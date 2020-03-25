using LeMieAttivita.Data;
using LeMieAttivita.Models;
using LeMieAttivita.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeMieAttivita.Services
{
    public class ApiTokenService
    {
        private readonly LeMieAttivitaContext _context;

        public ApiTokenService(LeMieAttivitaContext context)
        {
            _context = context;
        }

        public void Insert(ApiToken apiToken)
        {
            _context.Add(apiToken);
            _context.SaveChanges();
        }

        public void Update(ApiToken apiToken)
        {
            _context.Update(apiToken);
            _context.SaveChanges();
        }

        public ApiToken FindByRefreshToken(string refreshToken)
        {
            if (_context.ApiToken.Any())
            {
                return _context.ApiToken.Where(x => x.RefreshToken == refreshToken).FirstOrDefault();
            }
            else
            {
                throw new NotFoundException("Refresh Token Not Found.");
            }
        }

        public List<ApiToken> FindAll()
        {
            return _context.ApiToken.ToList();
        }

        public ApiToken FindById(int? apiTokenId)
        {
            if (!_context.ApiToken.Any(apiToken => apiToken.Id == apiTokenId))
            {
                throw new NotFoundException("ApiTokenId was not found!");
            }
            return _context.ApiToken.Find(apiTokenId);
        }
    }
}
