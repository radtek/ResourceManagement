﻿/*******************************************************************************
 * Copyright © 2016 DaleCloud.Framework 版权所有
 * Author: DaleCloud
 * Description: 快速开发平台
 * Website：
*********************************************************************************/
using System;

namespace IGrow.Entity
{
    public interface IDeleteAudited 
    {
        /// <summary>
        /// 逻辑删除标记
        /// </summary>
        bool? DeleteMark { get; set; }

        /// <summary>
        /// 删除实体的用户
        /// </summary>
        string DeleteUserId { get; set; }

        /// <summary>
        /// 删除实体时间
        /// </summary>
        DateTime? DeleteTime { get; set; } 
    }
}