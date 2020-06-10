using System;
using System.Collections.Generic;
using CS321_W2D1_BlogAPI.Models;

namespace CS321_W2D1_BlogAPI.Services
{
    public interface IPostService
    {
        Post Add(Post post);            //CREATE
        Post Get(int id);               //READ
        Post Update(Post post);         //UPDATE
        void Remove(Post post);         //DELETE
        IEnumerable<Post> GetAll();     //LIST
    }
}
