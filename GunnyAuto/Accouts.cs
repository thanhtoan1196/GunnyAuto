using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace GunnyAuto
{
    public class Accounts
    {
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class GunnyAuto
        {

            private List<GunnyAutoGame> gameField = new List<GunnyAutoGame>();

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Game")]
            public List<GunnyAutoGame> Game
            {
                get
                {
                    return this.gameField;
                }
                set
                {
                    this.gameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GunnyAutoGame
        {

            private GunnyAutoGameLoginTab loginTabField;

            /// <remarks/>
            public GunnyAutoGameLoginTab LoginTab
            {
                get
                {
                    return this.loginTabField;
                }
                set
                {
                    this.loginTabField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class GunnyAutoGameLoginTab
        {

            private string serverField;

            private string playerField;

            private string userField;

            private string passField;

            private sbyte channelField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string server
            {
                get
                {
                    return this.serverField;
                }
                set
                {
                    this.serverField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string player
            {
                get
                {
                    return this.playerField;
                }
                set
                {
                    this.playerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string user
            {
                get
                {
                    return this.userField;
                }
                set
                {
                    this.userField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string pass
            {
                get
                {
                    return this.passField;
                }
                set
                {
                    this.passField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public sbyte channel
            {
                get
                {
                    return this.channelField;
                }
                set
                {
                    this.channelField = value;
                }
            }
        }

    }
}
