//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.5485
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
//This source code was auto-generated by MonoXSD
//
namespace Schemas {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class HeroConfig {
        
        private HeroConfigHeros[] herosField;
        
        private HeroConfigBaseAttrPercent[] baseAttrPercentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Heros")]
        public HeroConfigHeros[] Heros {
            get {
                return this.herosField;
            }
            set {
                this.herosField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BaseAttrPercent")]
        public HeroConfigBaseAttrPercent[] BaseAttrPercent {
            get {
                return this.baseAttrPercentField;
            }
            set {
                this.baseAttrPercentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class HeroConfigHeros {
        
        private string idField;
        
        private string nameField;
        
        private sbyte sexField;
        
        private bool sexFieldSpecified;
        
        private string infoField;
        
        private int iconField;
        
        private string modelField;
        
        private bool hitFlyField;
        
        private bool hitBackField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte Sex {
            get {
                return this.sexField;
            }
            set {
                this.sexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SexSpecified {
            get {
                return this.sexFieldSpecified;
            }
            set {
                this.sexFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Info {
            get {
                return this.infoField;
            }
            set {
                this.infoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Icon {
            get {
                return this.iconField;
            }
            set {
                this.iconField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Model {
            get {
                return this.modelField;
            }
            set {
                this.modelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HitFly {
            get {
                return this.hitFlyField;
            }
            set {
                this.hitFlyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HitBack {
            get {
                return this.hitBackField;
            }
            set {
                this.hitBackField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class HeroConfigBaseAttrPercent {
        
        private int idField;
        
        private int hpField;
        
        private int mpField;
        
        private int blkField;
        
        private int atkField;
        
        private int defField;
        
        private int magAtkField;
        
        private int magDefField;
        
        private int critField;
        
        private int critDmgField;
        
        private int moveSpeedField;
        
        private int jumpSpeed1Field;
        
        private int jumpSpeed2Field;
        
        private int regainHpField;
        
        private int regainMpField;
        
        private int regainBlockField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Hp {
            get {
                return this.hpField;
            }
            set {
                this.hpField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Mp {
            get {
                return this.mpField;
            }
            set {
                this.mpField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Blk {
            get {
                return this.blkField;
            }
            set {
                this.blkField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Atk {
            get {
                return this.atkField;
            }
            set {
                this.atkField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Def {
            get {
                return this.defField;
            }
            set {
                this.defField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int MagAtk {
            get {
                return this.magAtkField;
            }
            set {
                this.magAtkField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int MagDef {
            get {
                return this.magDefField;
            }
            set {
                this.magDefField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Crit {
            get {
                return this.critField;
            }
            set {
                this.critField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int CritDmg {
            get {
                return this.critDmgField;
            }
            set {
                this.critDmgField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int MoveSpeed {
            get {
                return this.moveSpeedField;
            }
            set {
                this.moveSpeedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int JumpSpeed1 {
            get {
                return this.jumpSpeed1Field;
            }
            set {
                this.jumpSpeed1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int JumpSpeed2 {
            get {
                return this.jumpSpeed2Field;
            }
            set {
                this.jumpSpeed2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int RegainHp {
            get {
                return this.regainHpField;
            }
            set {
                this.regainHpField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int RegainMp {
            get {
                return this.regainMpField;
            }
            set {
                this.regainMpField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int RegainBlock {
            get {
                return this.regainBlockField;
            }
            set {
                this.regainBlockField = value;
            }
        }
    }
}
