using Breeze.ContextProvider;
using Breeze.ContextProvider.EF6;
using Breeze.WebApi2;
using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace spjeff_partners_web.Controllers
{
    [BreezeController]
    public class PartnersController : ApiController
    {
        readonly EFContextProvider<PartnerEntities> _contextProvider = new EFContextProvider<PartnerEntities>();

        // ~/breeze/todos/Metadata 
        [HttpGet]
        public string Metadata()
        {
            return _contextProvider.Metadata();
        }

        // ~/breeze/todos/Todos
        // ~/breeze/todos/Todos?$filter=IsArchived eq false&$orderby=CreatedAt 
        [HttpGet]
        public IQueryable<Addresses> Addresses()
        {
            return _contextProvider.Context.Addresses;
        }
        [HttpGet]
        public IQueryable<AddressTypes> AddressTypes()
        {
            return _contextProvider.Context.AddressTypes;
        }
        [HttpGet]
        public IQueryable<AgreementDocumentMetaData> AgreementDocumentMetaData()
        {
            return _contextProvider.Context.AgreementDocumentMetaData;
        }

        [HttpGet]
        public IQueryable<AgreementDocuments> AgreementDocuments()
        {
            return _contextProvider.Context.AgreementDocuments;
        }
        [HttpGet]
        public IQueryable<AgreementDocumentTypes> AgreementDocumentTypes()
        {
            return _contextProvider.Context.AgreementDocumentTypes;
        }
        [HttpGet]
        public IQueryable<Communications> Communications()
        {
            return _contextProvider.Context.Communications;
        }
        [HttpGet]
        public IQueryable<DocumentPrivacy> DocumentPrivacy()
        {
            return _contextProvider.Context.DocumentPrivacy;
        }
        [HttpGet]
        public IQueryable<ForumComments> ForumComments()
        {
            return _contextProvider.Context.ForumComments;
        }
        [HttpGet]
        public IQueryable<Forums> Forums()
        {
            return _contextProvider.Context.Forums;
        }
        [HttpGet]
        public IQueryable<ForumThreads> ForumThreads()
        {
            return _contextProvider.Context.ForumThreads;
        }
        [HttpGet]
        public IQueryable<PartnerDocumentMetaData> PartnerDocumentMetaData()
        {
            return _contextProvider.Context.PartnerDocumentMetaData;
        }
        [HttpGet]
        public IQueryable<PartnerDocuments> PartnerDocuments()
        {
            return _contextProvider.Context.PartnerDocuments;
        }
        [HttpGet]
        public IQueryable<PartnerDocumentTypes> PartnerDocumentTypes()
        {
            return _contextProvider.Context.PartnerDocumentTypes;
        }
        [HttpGet]
        public IQueryable<Roles> Roles()
        {
            return _contextProvider.Context.Roles;
        }
        [HttpGet]
        public IQueryable<UserParks> UserParks()
        {
            return _contextProvider.Context.UserParks;
        }
        [HttpGet]
        public IQueryable<UserPartners> UserPartners()
        {
            return _contextProvider.Context.UserPartners;
        }
        [HttpGet]
        public IQueryable<UserRegions> UserRegions()
        {
            return _contextProvider.Context.UserRegions;
        }
        [HttpGet]
        public IQueryable<Users> Users()
        {
            return _contextProvider.Context.Users;
        }


        // ~/breeze/todos/SaveChanges
        [HttpPost]
        public SaveResult SaveChanges(JObject saveBundle)
        {
            return _contextProvider.SaveChanges(saveBundle);
        }
    }
}
