﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.UseCases.GetAllUsers
{
    public sealed record GetAllUserRequest :
                   IRequest<List<GetAllUserResponse>>;
}
