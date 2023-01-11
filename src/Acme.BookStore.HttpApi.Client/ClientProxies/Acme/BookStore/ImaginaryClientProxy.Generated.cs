// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using Acme.BookStore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.Http.Modeling;

// ReSharper disable once CheckNamespace
namespace Acme.BookStore;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IImaginaryAppService), typeof(ImaginaryClientProxy))]
public partial class ImaginaryClientProxy : ClientProxyBase<IImaginaryAppService>, IImaginaryAppService
{
    public virtual async Task<ListResultDto<KeyValuePair<Guid, String>>, > GetMyStuffAsync()
    {
        return await RequestAsync<ListResultDto<KeyValuePair<Guid, String>>, >(nameof(GetMyStuffAsync));
    }
}
