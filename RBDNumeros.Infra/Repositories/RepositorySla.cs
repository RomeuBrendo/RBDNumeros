﻿using RBDNumeros.Domain.Entities;
using RBDNumeros.Domain.Interfaces.Repositories;
using RBDNumeros.Infra.Repositories.Base;
using System;

namespace RBDNumeros.Infra.Repositories
{
    public class RepositorySla : RepositoryBase<Sla, Guid>, IRepositorySla
    {
        private readonly RBDNumerosContext _context;
        public RepositorySla(RBDNumerosContext context) : base(context)
        {
            _context = context;
        }
    }
    
}
