namespace InshareDesignPattern
{
    public abstract partial class AttributeComponents : Components
    {
        protected DataType DataTypes;
        protected object Value;
        public AttributeComponents(int id, string name, string dataType, string value) : base(id, name)
        {
            Enum.TryParse(dataType.ToUpper(), out this.DataTypes).ToString();
            object success = 0;
            switch (DataTypes)
            {
                case DataType.INTEGER:
                    try
                    {
                        success = Convert.ToInt32(value);
                    }
                    catch (Exception e)
                    {

                        success = e.Message;
                    }
                    break;
                case DataType.STRING:
                    try
                    {
                        success = Convert.ToString(value);
                    }
                    catch (Exception e)
                    {

                        success = e.Message;
                    }
                    break;
                case DataType.BOOLEAN:
                    try
                    {
                        success = Convert.ToBoolean(value);
                    }
                    catch (Exception e)
                    {

                        success = e.Message;
                    }
                    break;
                case DataType.DECIMAL:
                    try
                    {
                        success = Convert.ToDecimal(value);
                    }
                    catch (Exception e)
                    {

                        success = e.Message;
                    }
                    break;
                case DataType.LIST:
                    break;
                case DataType.DATE:
                    try
                    {
                        success = Convert.ToDateTime(value);
                    }
                    catch (Exception e)
                    {

                        success = e.Message;
                    }
                    break;
                default:
                    success = string.Empty;
                    break;
            }
            this.Value = success;
        }
    }
}
