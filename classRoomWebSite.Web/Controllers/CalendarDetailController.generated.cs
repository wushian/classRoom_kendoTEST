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
    public partial class CalendarDetailController : ApiController
    {
        private classRoomWebSite.Data.classRoomWebSiteDataContext _context = new classRoomWebSite.Data.classRoomWebSiteDataContext();

        #region Get

        public classRoomWebSite.Data.CalendarDetail GetByKey(System.Guid identification)
        {
            var calendarDetail = _context.CalendarDetail.GetByKey(identification);
            if (calendarDetail == null)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));

            return calendarDetail;
        }

        public IQueryable<classRoomWebSite.Data.CalendarDetail> GetAll()
        {
            return _context.CalendarDetail.AsQueryable();
        }

        public IQueryable<classRoomWebSite.Data.CalendarDetail> GetBySubject(System.String subject)
        {
            return _context.CalendarDetail.BySubject(subject).AsQueryable();
        }

        public IQueryable<classRoomWebSite.Data.CalendarDetail> GetByStartDateTime(System.DateTime? startDateTime)
        {
            return _context.CalendarDetail.ByStartDateTime(startDateTime).AsQueryable();
        }

        public IQueryable<classRoomWebSite.Data.CalendarDetail> GetByEndDateTime(System.DateTime? endDateTime)
        {
            return _context.CalendarDetail.ByEndDateTime(endDateTime).AsQueryable();
        }

        public IQueryable<classRoomWebSite.Data.CalendarDetail> GetByFeeStaff(System.Int32? feeStaff)
        {
            return _context.CalendarDetail.ByFeeStaff(feeStaff).AsQueryable();
        }

        public IQueryable<classRoomWebSite.Data.CalendarDetail> GetByFeeNonStaff(System.Int32? feeNonStaff)
        {
            return _context.CalendarDetail.ByFeeNonStaff(feeNonStaff).AsQueryable();
        }

        public IQueryable<classRoomWebSite.Data.CalendarDetail> GetByContact(System.String contact)
        {
            return _context.CalendarDetail.ByContact(contact).AsQueryable();
        }

        public IQueryable<classRoomWebSite.Data.CalendarDetail> GetByContactTel(System.String contactTel)
        {
            return _context.CalendarDetail.ByContactTel(contactTel).AsQueryable();
        }

        public IQueryable<classRoomWebSite.Data.CalendarDetail> GetByDescribe(System.String describe)
        {
            return _context.CalendarDetail.ByDescribe(describe).AsQueryable();
        }

        #endregion

        public HttpResponseMessage Post(classRoomWebSite.Data.CalendarDetail value)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.BadRequest));

            _context.CalendarDetail.AddObject(value);
            _context.SaveChanges();

            var response = Request.CreateResponse<classRoomWebSite.Data.CalendarDetail>(HttpStatusCode.Created, value);
            response.Headers.Location = new Uri( Url.Link("DefaultApi", new { Identification = value.Identification }));

            return response;
        }

        public HttpResponseMessage Put(classRoomWebSite.Data.CalendarDetail value)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.BadRequest));

            var calendarDetail = _context.CalendarDetail.GetByKey(value.Identification);
            if (calendarDetail == null)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));

            _context.ApplyCurrentValues(calendarDetail.EntityKey.EntitySetName, value);
            _context.SaveChanges();

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        public HttpResponseMessage Delete(System.Guid identification)
        {
            var calendarDetail = _context.CalendarDetail.GetByKey(identification);
            if (calendarDetail == null)
                return new HttpResponseMessage(HttpStatusCode.NotFound);

            _context.CalendarDetail.DeleteObject(calendarDetail);
            _context.SaveChanges();
            
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
