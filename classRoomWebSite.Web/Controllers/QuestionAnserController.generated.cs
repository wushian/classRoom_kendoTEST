﻿#pragma warning disable 1591
// <auto-generated>
//     This code was generated from a CodeSmith Generator template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CodeSmith.Data.Linq;
using CodeSmith.Data.Linq.Dynamic;
using classRoomWebSite.Data;

namespace classRoomWebSite.Data.Controllers.API
{
    [CodeSmith.Data.Web.Http.PagingAndFiltering]
    public partial class QuestionAnserController : ApiController
    {
        private classRoomWebSite.Data.classRoomWebSiteDataContext _context = new classRoomWebSite.Data.classRoomWebSiteDataContext();

        #region Get

        public classRoomWebSite.Data.QuestionAnser GetByKey(System.Guid identification)
        {
            var questionAnser = _context.QuestionAnser.GetByKey(identification);
            if (questionAnser == null)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));

            return questionAnser;
        }

        public IQueryable<classRoomWebSite.Data.QuestionAnser> GetAll()
        {
            return _context.QuestionAnser.AsQueryable();
        }

        public IQueryable<classRoomWebSite.Data.QuestionAnser> GetByCat1(System.Int32? cat1)
        {
            return _context.QuestionAnser.ByCat1(cat1).AsQueryable();
        }

        public IQueryable<classRoomWebSite.Data.QuestionAnser> GetByCat2(System.Int32? cat2)
        {
            return _context.QuestionAnser.ByCat2(cat2).AsQueryable();
        }

        public IQueryable<classRoomWebSite.Data.QuestionAnser> GetByPic1(System.String pic1)
        {
            return _context.QuestionAnser.ByPic1(pic1).AsQueryable();
        }

        public IQueryable<classRoomWebSite.Data.QuestionAnser> GetByPic2(System.String pic2)
        {
            return _context.QuestionAnser.ByPic2(pic2).AsQueryable();
        }

        public IQueryable<classRoomWebSite.Data.QuestionAnser> GetByDescribe(System.String describe)
        {
            return _context.QuestionAnser.ByDescribe(describe).AsQueryable();
        }

        #endregion

        public HttpResponseMessage Post(classRoomWebSite.Data.QuestionAnser value)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.BadRequest));

            _context.QuestionAnser.AddObject(value);
            _context.SaveChanges();

            var response = Request.CreateResponse<classRoomWebSite.Data.QuestionAnser>(HttpStatusCode.Created, value);
            response.Headers.Location = new Uri( Url.Link("DefaultApi", new { Identification = value.Identification }));

            return response;
        }

        public HttpResponseMessage Put(classRoomWebSite.Data.QuestionAnser value)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.BadRequest));

            var questionAnser = _context.QuestionAnser.GetByKey(value.Identification);
            if (questionAnser == null)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));

            _context.ApplyCurrentValues(questionAnser.EntityKey.EntitySetName, value);
            _context.SaveChanges();

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        public HttpResponseMessage Delete(System.Guid identification)
        {
            var questionAnser = _context.QuestionAnser.GetByKey(identification);
            if (questionAnser == null)
                return new HttpResponseMessage(HttpStatusCode.NotFound);

            _context.QuestionAnser.DeleteObject(questionAnser);
            _context.SaveChanges();
            
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
