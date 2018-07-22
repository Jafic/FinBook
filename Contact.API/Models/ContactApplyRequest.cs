using System;
using System.Collections.Generic;

namespace Contact.API.Models
{
    public class ContactApplyRequest
    {
        /// <summary>
        /// �û�id
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// �û�����
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// ��˾
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// ְλ
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// ͷ���ַ
        /// </summary>
        public string Avatar { get; set; }
        /// <summary>
        /// �������û�id
        /// </summary>
        public int ApplierId { get; set; }
        /// <summary>
        /// �Ƿ�ͨ�� 0 δͨ�� 1 ��ͨ��
        /// </summary>
        public int Approvaled { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime ApplyTime { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime HandleTime { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime CreateTime { get; set; }

    }
}