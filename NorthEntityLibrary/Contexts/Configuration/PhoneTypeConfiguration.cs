﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using NorthEntityLibrary.Models;
using System;

namespace NorthEntityLibrary.Contexts
{
    public class PhoneTypeConfiguration : IEntityTypeConfiguration<PhoneType>
    {
        public void Configure(EntityTypeBuilder<PhoneType> entity)
        {
            entity.HasKey(e => e.PhoneTypeIdenitfier);
        }
    }
}
