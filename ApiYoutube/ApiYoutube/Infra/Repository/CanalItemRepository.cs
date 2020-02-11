using ApiYoutube.Context;
using ApiYoutube.Infra.Interfaces;
using ApiYoutube.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiYoutube.Infra.Repository
{
    public class CanalItemRepository : RepositoryBasic<CanalItem>, ICanalItemRepository
    {
        public CanalItemRepository(ApiYoutubeContext apiYoutubeContext) : base(apiYoutubeContext)
        {

        }
    }
}
