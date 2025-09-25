﻿using Contal.Cgp.Globals;
using Contal.Cgp.NCAS.Server.Beans;
using Contal.Cgp.Server.Beans;

namespace Contal.Cgp.NCAS.Server.DB
{
    public sealed class DoorEnvironmentAlarmArcs : ANcasBaseOrmTable<DoorEnvironmentAlarmArcs, DoorEnvironmentAlarmArc>
    {
        private DoorEnvironmentAlarmArcs()
            : base(null)
        {
        }

        public override bool HasAccessView(Login login)
        {
            return false;
        }

        public override bool HasAccessInsert(Login login)
        {
            return false;
        }

        public override bool HasAccessUpdate(Login login)
        {
            return false;
        }

        public override bool HasAccessDelete(Login login)
        {
            return false;
        }

        public override ObjectType ObjectType
        {
            get { return ObjectType.DoorEnvironmentAlarmArc; }
        }

        protected override void LoadObjectsInRelationshipGetById(DoorEnvironmentAlarmArc obj)
        {
            obj.DoorEnvironment = DoorEnvironments.Singleton.GetById(obj.DoorEnvironment.IdDoorEnvironment);
            obj.AlarmArc = AlarmArcs.Singleton.GetById(obj.AlarmArc.IdAlarmArc);
        }
    }
}
