using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InnovationWebApp.Models.InnovateDb
{
  [Table("idea")]
  public partial class Idea
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id
    {
      get;
      set;
    }
    public string firstName
    {
      get;
      set;
    }
    public string lastName
    {
      get;
      set;
    }
    public string email
    {
      get;
      set;
    }
    public string business
    {
      get;
      set;
    }
    public string office
    {
      get;
      set;
    }
    public string ideaDescription
    {
      get;
      set;
    }
    public string scope
    {
      get;
      set;
    }
    public DateTime date
    {
      get;
      set;
    }
    public int? votes
    {
      get;
      set;
    }
  }
}
