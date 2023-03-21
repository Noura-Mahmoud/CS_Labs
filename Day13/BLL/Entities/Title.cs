using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Title:EntityBase
    {
		string title_id;
        public string Title_id 
		{ get => title_id;
			set
			{
				if(value != title_id)
				{
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Changed;
					title_id = value;
				}
			}
		}
		string titleName;
        public string TitleName 
		{ get => titleName;
			set
			{
                if (value != titleName)
				{
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Changed;
                    titleName = value;
				}
            }
		}
		string type;
        public string Type { get => type;
			set
			{
                if (value != type)
				{
                    if (this.State != EntityState.Added)
                        this.State= EntityState.Changed;
					type = value;
				}
			}
		}
		string? pub_id;
        public string? Pub_id 
		{ get => pub_id;
			set 
			{
                if (value != pub_id)
				{
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Changed;
					pub_id = value;
				}
			}
		}
		decimal? price;
		public decimal? Price 
		{ get => price;
			set 
			{
                if (value != price)
				{
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Changed;
					price = value;
				}
			} 
		}
		decimal? advance;
        public decimal? Advance { get => advance;
			set
			{
                if (value != Advance)
				{
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Changed;
					advance = value;
				}
			}
		}
		int? royalty;
		public int? Royalty { get => royalty;
			set
			{
				if(value != royalty)
				{
					if(this.State != EntityState.Added)
						this.State = EntityState.Changed;
					royalty = value;
				}
			}
		}
		int? ytd_sales;
        public int? Ytd_sales { get => ytd_sales;
			set 
			{
                if (value != ytd_sales)
				{
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Changed;
					ytd_sales = value;
				}
			}
		}
		string? notes;
        public string? Notes { get => notes;
			set
			{
                if (value != notes)
				{
                    if (this.State != EntityState.Added)

                        this.State = EntityState.Changed;
					notes = value;
				}
			}
		}
		DateTime pubdate;
        public DateTime Pubdate { get => pubdate; 
			set 
			{
                if (value != pubdate)
				{
					if (this.State != EntityState.Added)
	                    this.State = EntityState.Changed;
					pubdate = value;
				}
			} }
	}
}
