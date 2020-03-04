using System;
using DevExpress.Xpo;
namespace ServerModeGridProjects {

    public class ServerSideGridTest :XPBaseObject {
        int fOID;
        [Key(true)]
        public int OID {
            get { return fOID; }
            set { SetPropertyValue<int>("OID", ref fOID, value); }
        }
        string fSubject;
        public string Subject {
            get { return fSubject; }
            set { SetPropertyValue<string>("Subject", ref fSubject, value); }
        }
        string fFrom;
        public string From {
            get { return fFrom; }
            set { SetPropertyValue<string>("From", ref fFrom, value); }
        }
        DateTime fSent;
        public DateTime Sent {
            get { return fSent; }
            set { SetPropertyValue<DateTime>("Sent", ref fSent, value); }
        }
        long fSize;
        public long Size {
            get { return fSize; }
            set { SetPropertyValue<long>("Size", ref fSize, value); }
        }
        bool fHasAttachment;
        public bool HasAttachment {
            get { return fHasAttachment; }
            set { SetPropertyValue<bool>("HasAttachment", ref fHasAttachment, value); }
        }
        public ServerSideGridTest(Session session) : base(session) { }
        public ServerSideGridTest() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
