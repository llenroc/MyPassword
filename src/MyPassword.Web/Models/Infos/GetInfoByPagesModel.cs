﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Abp.AutoMapper;
using MyPassword.Info.Dto;

namespace MyPassword.Web.Models.Infos
{
    [AutoMapTo(typeof(GetInfoByPageInput))]
    public class GetInfoByPagesModel: PageRequestModelBase
    {
        public string Title { get; set; }
        public string UserName { get; set; }
    }
}