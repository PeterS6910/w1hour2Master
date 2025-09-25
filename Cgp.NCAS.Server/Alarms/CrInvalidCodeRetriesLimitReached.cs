﻿using System;

using Contal.Cgp.Globals;
using Contal.Cgp.NCAS.Server.DB;
using Contal.Cgp.NCAS.Server.ServerAlarms;
using Contal.Cgp.Server.Alarms;
using Contal.IwQuick.Data;

namespace Contal.Cgp.NCAS.Server.Alarms
{
    [LwSerialize(755)]
    public class CrInvalidCodeRetriesLimitReached : Alarm, ICreateServerAlarm
    {
        private CrInvalidCodeRetriesLimitReached()
        {

        }

        public ServerAlarm CreateServerAlarm(Guid idCcu)
        {
            var ccu = CCUs.Singleton.GetById(idCcu);

            if (ccu == null)
                return null;

            var cardReader = CardReaders.Singleton.GetById(AlarmKey.AlarmObject.Id);

            if (cardReader == null)
                return null;

            return new CrInvalidCodeRetriesLimitReachedServerAlarm(
                ccu,
                cardReader,
                new Alarm(
                    Id,
                    AlarmKey,
                    CreatedDateTime,
                    AlarmState,
                    IsAcknowledged,
                    IsBlockedGeneral,
                    IsBlockedIndividual));
        }
    }
}
