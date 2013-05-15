using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;
using System.Data.Common;

namespace SOA.ORM
{
    [Synchro]
    public partial class SaveEvidenceProceAudit
    {
        /// <summary>
        /// 获取先行登记保存证据处理审批表记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        internal EList<SaveEvidenceProceAudit> SaveEvidenceProceAuditGetAll(int page, int pageSize, string PutOnRecordCaseName)
        {
            EList<SaveEvidenceProceAudit> SaveEvidenceProceAudits = new EList<SaveEvidenceProceAudit>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (PutOnRecordCaseName != "")
                Clips.Add(DataBases.SaveEvidenceProceAudit.PutOnRecordCaseName.Like("%" + PutOnRecordCaseName + "%"));
            Clips.Add(DataBases.SaveEvidenceProceAudit.Status < 2);
            SelectSqlSection section = DB.Select(DataBases.SaveEvidenceProceAudit, DataBases.SaveEvidenceProceAudit.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            SaveEvidenceProceAudits.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.SaveEvidenceProceAudit);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.SaveEvidenceProceAudit.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        SaveEvidenceProceAudit putOnRecord = ReadRow(reader);
                        SaveEvidenceProceAudits.Items.Add(putOnRecord);
                    }
                }
            }

            return SaveEvidenceProceAudits;
        }
    }
}
