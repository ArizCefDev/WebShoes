﻿using DataAccess.Entity;
using DTO.DTOEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMessageService
        : IBaseService<MessageDTO, Message, MessageDTO>
    {
    }
}
