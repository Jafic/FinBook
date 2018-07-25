using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace Contact.API.Models
{
    [BsonIgnoreExtraElements]
    public class Contact
    {
        public Contact()
        {
            Tags = new List<string>();
        }
        /// <summary>
        /// �û�id
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// �û�����
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// ͷ���ַ
        /// </summary>
        public string Avatar { get; set; }
        /// <summary>
        /// ��˾
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// ְλ
        /// </summary>
        public string Title { get; set; }

        public List<string> Tags { get; set; }
    }
}