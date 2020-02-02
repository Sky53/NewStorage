﻿using Storage.Business.DTO.UserDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Business.Users
{
    public interface IUserService
    {
        public Task<int> AddAsync(UserRequest userRequest);

        public Task<UserResponse> GetByIdAsync(int id);

        public Task<UserResponse> UpdateAsync(int id, UserRequest userRequest);

        public Task DeleteAsync(int id);
    }
}
