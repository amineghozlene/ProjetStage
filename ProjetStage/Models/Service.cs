using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetStage.Models
{
    public class Service
    {
        private int idService;
        public virtual int IdService
        {
            get { return idService; }
            set { idService = value; }
        }
        private String title;
        public virtual String LastName
        {
            get { return title; }
            set { title = value; }
        }
        private byte[] image;
        public virtual byte[] Image
        {
            get { return image; }
            set { image = value; }
        }
        private string description;
        public virtual string Description
        {
            get { return description; }
            set { description = value; }
        }
        private float prixHT;
        public virtual float PrixHT
        {
            get { return prixHT; }
            set { prixHT = value; }
        }
        private Boolean active;
        public virtual Boolean Active
        {
            get { return active; }
            set { active = value; }
        }
    }
}