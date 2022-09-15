//namespace InshareDesignPattern
//{

//    public class AttributesValue : Components
//    {
//        public DataType DataTypes { get; }
//        private readonly Attributes attributes;

//        protected object Value;
//        public AttributesValue(int id, string value) : base(id, value)
//        {

//            object success = 0;
//            switch (DataTypes)
//            {
//                case DataType.INTEGER:
//                    try
//                    {
//                        success = Convert.ToInt32(value);
//                    }
//                    catch (Exception e)
//                    {

//                        success = e.Message;
//                    }
//                    break;
//                case DataType.STRING:
//                    try
//                    {
//                        success = Convert.ToString(value);
//                    }
//                    catch (Exception e)
//                    {

//                        success = e.Message;
//                    }
//                    break;
//                case DataType.BOOLEAN:
//                    try
//                    {
//                        success = Convert.ToBoolean(value);
//                    }
//                    catch (Exception e)
//                    {

//                        success = e.Message;
//                    }
//                    break;
//                case DataType.DECIMAL:
//                    try
//                    {
//                        success = Convert.ToDecimal(value);
//                    }
//                    catch (Exception e)
//                    {

//                        success = e.Message;
//                    }
//                    break;
//                case DataType.LIST:
//                    break;
//                case DataType.DATE:
//                    try
//                    {
//                        success = Convert.ToDateTime(value);
//                    }
//                    catch (Exception e)
//                    {

//                        success = e.Message;
//                    }
//                    break;
//                default:
//                    success = string.Empty;
//                    break;
//            }
//            this.Value = success;
//            return;
//        }

//        public override void Add(Components c)
//        {
//            Console.WriteLine("Cannot Add to Leaf");
//        }

//        public override void Dsiplay(int indent)
//        {
//            Console.WriteLine(new String(' ', indent) + "- Value: " + Value);
//        }

//        public override void Remove(Components c)
//        {
//            Console.WriteLine("Cannot Remove from Leaf");
//        }
//    }

//}
