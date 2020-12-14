using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Collections;

namespace ahbsd.lib.lexoffice
{
    public class ContactList
    {
        public List<Contact> Content { get; private set; }
        public bool First { get; set; }
        public bool Last { get; set; }
        public int TotalPages { get; set; }
        public int TotalElements { get; set; }
        public int NumberOfElements { get; set; }
        public int Size { get; set; }
        public int Number { get; set; }
        public ArrayList Sort { get; private set; }

        public ContactList()
        {
            Content = new List<Contact>();
            Sort = new ArrayList();
        }

        /*
        public bool first;
        public bool last;
        public int totalPages;
        public int totalElements;
        public int numberOfElements;
        public int size;
        public int number;
        public object[] sort;
        */
    }
}
