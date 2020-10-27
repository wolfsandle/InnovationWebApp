using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InnovationWebApp.Models.InnovateDb
{
  [Table("votes")]
  public partial class Vote
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int voteid
    {
      get;
      set;
    }
    public string email
    {
      get;
      set;
    }
    public int id
    {
      get;
      set;
    }
  }
}
