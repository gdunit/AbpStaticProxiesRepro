using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Identity;

namespace Acme.BookStore;

public interface IImaginaryAppService : IApplicationService, IDoesMoreStuff<IdentityUserDto>
{
    Task<ListResultDto<KeyValuePair<Guid, string>>> GetMyStuffAsync();
}