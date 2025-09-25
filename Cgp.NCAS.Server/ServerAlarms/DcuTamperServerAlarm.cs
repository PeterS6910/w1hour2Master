﻿using System;
using System.Collections.Generic;
using System.Linq;

using Contal.Cgp.Globals;
using Contal.Cgp.Globals.PlatformPC;
using Contal.Cgp.NCAS.Server.Beans;
using Contal.Cgp.NCAS.Server.DB;
using Contal.Cgp.Server.Alarms;
using Contal.Cgp.Server.Beans;
using Contal.IwQuick.Data;

namespace Contal.Cgp.NCAS.Server.ServerAlarms
{
    [LwSerialize(817)]
    public class DcuTamperServerAlarm : ServerAlarm
    {
        private DcuTamperServerAlarm()
        {

        }

        public DcuTamperServerAlarm(
            CCU ccu,
            DCU dcu,
            Alarm alarm)
            : base(
                new ServerAlarmCore(
                    ccu.IdCCU,
                    alarm,
                    new LinkedList<IdAndObjectType>(
                        GetParentObjects(ccu.IdCCU)),
                    GetName(dcu),
                    ccu.Name,
                    string.Format(
                        "DCU tamper: {0}",
                        dcu.Name)))
        {

        }

        public static string GetName(DCU dcu)
        {
            return string.Format(
                "{0} : {1}",
                AlarmType.DCU_TamperSabotage,
                dcu.ToString());
        }

        private static IEnumerable<IdAndObjectType> GetParentObjects(
            Guid idCcu)
        {
            var parentObjects = Enumerable.Repeat(
                new IdAndObjectType(
                    idCcu,
                    ObjectType.CCU),
                1);

            return parentObjects;
        }

        public static IEnumerable<IdAndObjectType> GetRelatedObjects(
            Guid idCcu,
            DCU dcu)
        {
            var relatedObjects = GetParentObjects(idCcu);

            relatedObjects = relatedObjects.Concat(
                Enumerable.Repeat(
                    new IdAndObjectType(
                        dcu.IdDCU,
                        ObjectType.DCU),
                    1));

            return relatedObjects;
        }

        public override PresentationGroup GetPresentationGroup()
        {
            var dcu = DCUs.Singleton.GetById(ServerAlarmCore.Alarm.AlarmKey.AlarmObject.Id);

            return dcu != null && dcu.TamperSabotagePresentationGroup != null
                ? dcu.TamperSabotagePresentationGroup
                : DevicesAlarmSettings.Singleton.AlarmDcuTamperSabotagePresentationGroup();
        }
    }
}
