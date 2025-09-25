﻿using System;
using System.Collections.Generic;
using Contal.CatCom;
using Contal.Cgp.Globals;
using Contal.Cgp.NCAS.CCU.EventParameters;
using Contal.IwQuick.Data;

namespace Contal.Cgp.NCAS.CCU.Alarms
{
    [LwSerialize(750)]
    public class CcuUpsBatteryFaultAlarm :
        Alarm,
        ICreateEventAlarmOccured,
        ICreateEventAlarmChanged,
        IGetCreateAlarmFactoryWhenAlarmWasEnabled,
        ICreateCatAlarms
    {
        private class CreateAlarmFactoryWhenAlarmWasEnabled : ICreateAlarmFactoryWhenAlarmWasEnabled
        {
            private readonly Guid _idCcu;

            public CreateAlarmFactoryWhenAlarmWasEnabled(Guid idCcu)
            {
                _idCcu = idCcu;
            }

            Alarm ICreateAlarmFactoryWhenAlarmWasEnabled.CreateAlarm(bool processEvent)
            {
                if (processEvent)
                    ((ICreateAlarmFactoryWhenAlarmWasEnabled) this).CreateEvent();

                return new CcuUpsBatteryFaultAlarm(
                    _idCcu);
            }

            void ICreateAlarmFactoryWhenAlarmWasEnabled.CreateEvent()
            {
                Events.ProcessEvent(
                    new EventAlarmCcuUpsBatteryFault(true));
            }
        }

        public CcuUpsBatteryFaultAlarm()
        {

        }

        public CcuUpsBatteryFaultAlarm(Guid idCcu)
            : base(
                new AlarmKey(
                    AlarmType.Ccu_Ups_BatteryFault,
                    new IdAndObjectType(
                        idCcu,
                        ObjectType.CCU)),
                AlarmState.Alarm)
        {

        }

        public static AlarmKey CreateAlarmKey(Guid idCcu)
        {
            return new AlarmKey(
                AlarmType.Ccu_Ups_BatteryFault,
                new IdAndObjectType(
                    idCcu,
                    ObjectType.CCU));
        }

        public EventParameters.EventParameters CreateEventAlarmOccured()
        {
            return new EventAlarmOccuredOrChangedCcuUpsBatteryFault(
                true,
                this);
        }

        public EventParameters.EventParameters CreateEventAlarmChanged()
        {
            return new EventAlarmOccuredOrChangedCcuUpsBatteryFault(
                false,
                this);
        }

        public static void Update(
            Guid idCcu,
            bool isAlarm)
        {
            if (!isAlarm)
                AlarmsManager.Singleton.StopAlarm(
                    CreateAlarmKey(
                        idCcu));
            else
                AlarmsManager.Singleton.AddAlarm(
                    new CcuUpsBatteryFaultAlarm(
                        idCcu));
        }

        ICreateAlarmFactoryWhenAlarmWasEnabled IGetCreateAlarmFactoryWhenAlarmWasEnabled.GetCreateAlarmFactory()
        {
            var alarmObject = AlarmKey.AlarmObject;

            if (alarmObject == null)
                return null;

            return new CreateAlarmFactoryWhenAlarmWasEnabled((Guid) AlarmKey.AlarmObject.Id);
        }

        ICollection<CatAlarm> ICreateCatAlarms.CreateCatAlarms(bool alarmAcknowledged)
        {
            if (alarmAcknowledged
                || AlarmKey == null)
            {
                return null;
            }

            var alarmArcs = CatAlarmsManager.Singleton.GetAlarmArcs(
                AlarmKey.AlarmType,
                AlarmKey.AlarmObject);

            if (alarmArcs == null)
                return null;

            return new[]
            {
                CatAlarmsManager.CreateCcuAlarm(
                    AlarmEventCode.UpsBatteryFault,
                    this,
                    AlarmState,
                    AlarmKey.AlarmType,
                    alarmArcs)
            };
        }
    }
}
