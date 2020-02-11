using ApiYoutube.Context;
using ApiYoutube.Infra.Interfaces;
using ApiYoutube.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiYoutube.Infra.Repository
{
    public class CanalRepository : RepositoryBasic<Canal>, ICanalRepository
    {
        public CanalRepository(ApiYoutubeContext apiYoutubeContext) : base(apiYoutubeContext)
        {

        }
    }
}
