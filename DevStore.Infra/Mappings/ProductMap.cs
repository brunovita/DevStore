﻿using DevStore.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevStore.Infra.Mappings
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Product");

            HasKey(x => x.Id); // Diz que ID é a chave

            Property(x => x.Title).HasMaxLength(160).IsRequired();
            Property(x => x.Price).IsRequired();
            Property(x => x.AcquireDate).IsRequired();

            HasRequired(x => x.Category); // Faz a junção com as Categorias na hora de gerar o BD
        }
    }
}