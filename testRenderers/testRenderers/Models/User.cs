using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace testRenderers.Models
{
    public class User
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string Email { get; set; }
        public ImageSource Image { get; set; }
        public string Password { get; set; }
        public string Ville { get; set; }
        public int age;

        public User()
        {

        }
    }
}
