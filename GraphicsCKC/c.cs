﻿using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsCKC
{
    public class c
    {
        [CommandMethod("Cra")]
        public static void CreateAndAssignALayer()
        {
            // Get the current document and database
            Document acDoc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
            Database acCurDb = acDoc.Database;

            // Start a transaction
            using (Transaction acTrans = acCurDb.TransactionManager.StartTransaction())
            {
                // Open the Layer table for read
                LayerTable acLyrTbl;
                acLyrTbl = acTrans.GetObject(acCurDb.LayerTableId,
                                             OpenMode.ForRead) as LayerTable;

                string sLayerName = "Center";

                if (acLyrTbl.Has(sLayerName) == false)
                {
                    LayerTableRecord acLyrTblRec = new LayerTableRecord();

                    // Assign the layer the ACI color 1 and a name
                    acLyrTblRec.Color = Autodesk.AutoCAD.Colors.Color.FromRgb(Snap.color.R, Snap.color.G, Snap.color.B);
                    acLyrTblRec.Name = sLayerName;

                    // Upgrade the Layer table for write
                    acLyrTbl.UpgradeOpen();

                    // Append the new layer to the Layer table and the transaction
                    acLyrTbl.Add(acLyrTblRec);
                    acTrans.AddNewlyCreatedDBObject(acLyrTblRec, true);
                }

                // Open the Block table for read
                BlockTable acBlkTbl;
                acBlkTbl = acTrans.GetObject(acCurDb.BlockTableId,
                                             OpenMode.ForRead) as BlockTable;

                // Open the Block table record Model space for write
                BlockTableRecord acBlkTblRec;
                acBlkTblRec = acTrans.GetObject(acBlkTbl[BlockTableRecord.ModelSpace],
                                                OpenMode.ForWrite) as BlockTableRecord;

                // Create a circle object
                Circle acCirc = new Circle();
                acCirc.SetDatabaseDefaults();
                acCirc.Center = new Point3d(2, 2, 0);
                acCirc.Radius = 1;
                acCirc.Layer = sLayerName;

                acBlkTblRec.AppendEntity(acCirc);
                acTrans.AddNewlyCreatedDBObject(acCirc, true);

                // Save the changes and dispose of the transaction
                acTrans.Commit();
            }
        }
    }
}
