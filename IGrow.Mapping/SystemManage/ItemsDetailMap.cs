﻿using IGrow.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace IGrow.Mapping.SystemManage
{
    public class ItemsDetailMap : EntityTypeConfiguration<ItemsDetailEntity>
    {
        public ItemsDetailMap()
        {
            this.ToTable("Sys_ItemsDetail");
            this.HasKey(t => t.IGrowID);
        }
    }
}
