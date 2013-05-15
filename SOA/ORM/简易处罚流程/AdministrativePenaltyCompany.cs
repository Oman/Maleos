﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;
using System.Data.Common;

namespace SOA.ORM
{
    [Synchro]
    public partial class AdministrativePenaltyCompany
    {
        /// <summary>
        /// 行政处罚决定书(单位)记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        internal EList<AdministrativePenaltyCompany> AdministrativePenaltyCompanyGetAll(int page, int pageSize, string docTitle)
        {
            EList<AdministrativePenaltyCompany> AdministrativePenaltyCompanys = new EList<AdministrativePenaltyCompany>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (docTitle != "")
                Clips.Add(DataBases.AdministrativePenaltyCompany.DocTitle.Like("%" + docTitle + "%"));

            SelectSqlSection section = DB.Select(DataBases.AdministrativePenaltyCompany, DataBases.AdministrativePenaltyCompany.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            AdministrativePenaltyCompanys.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.AdministrativePenaltyCompany);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.AdministrativePenaltyCompany.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        AdministrativePenaltyCompany sdministrativePenaltyCompany = ReadRow(reader);
                        AdministrativePenaltyCompanys.Items.Add(sdministrativePenaltyCompany);
                    }
                }
            }

            return AdministrativePenaltyCompanys;
        }
    }
}
