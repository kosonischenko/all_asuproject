﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Entities;

namespace DAO
{
    public class PointsInfoDAO:UniversalDAO
    {
        public override UniversalEntity createEntity()
        {
            UniversalEntity ue = new UniversalEntity();

            while (dr.Read())
            {
                PointsInfo ent = new PointsInfo();
                ent = createEntityFromReader(dr);
                ue.Add(ent);
            }
            return ue;
        }

        public PointsInfo createEntityFromReader(SqlDataReader dr)
        {
            PointsInfo ent = new PointsInfo();

            if (!dr.IsDBNull(dr.GetOrdinal("ID")))
                ent.ID = Convert.ToInt32(dr["ID"]);

            if (!dr.IsDBNull(dr.GetOrdinal("PointsID")))
                ent.PointsID = Convert.ToInt32(dr["PointsID"]);

            if (!dr.IsDBNull(dr.GetOrdinal("UserID")))
                ent.UserID = Convert.ToInt32(dr["UserID"]);

            if (!dr.IsDBNull(dr.GetOrdinal("IsRepair")))
                ent.IsRepairs = Convert.ToBoolean(dr["IsRepair"]);

            return ent;
        }

        public UniversalEntity createEntity(SqlDataReader idr)
        {
            dr = idr;
            return createEntity();
        }
    }
}