﻿using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfRoomDal:GenericRepository<Room>,IRoomDal
    {
    }
}
