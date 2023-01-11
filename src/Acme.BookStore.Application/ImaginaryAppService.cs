using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Identity;

namespace Acme.BookStore;

public class ImaginaryAppService : ApplicationService, IImaginaryAppService
{
    public Task<IdentityUserDto> DoMoreStuffAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ListResultDto<KeyValuePair<Guid, string>>> GetMyStuffAsync()
    {
        throw new NotImplementedException();
    }
}