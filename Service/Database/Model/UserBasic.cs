using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Services.Database.Enum;
using Toolbelt.ComponentModel.DataAnnotations.Schema;

namespace Services.Database.Model
{
  public class UserBasic
  {
    [Key]
    public Guid Gid { get; set; }

    /// <summary>
    /// 帳號
    /// </summary>
    [Index]
    [Required]
    [MinLength(5)]
    [MaxLength(20)]
    public string UserId { get; set; }

    /// <summary>
    /// 密碼
    /// </summary>
    [Required]
    public string HashedPassword { get; set; }

    /// <summary>
    /// 帳號狀態
    /// </summary>
    [Required]
    [DefaultValue(true)]
    public Status Enable { get; set; }

    /// <summary>
    /// 角色權限
    /// </summary>
    [Required]
    [DefaultValue(0)]
    public Role Role { get; set; }

    /// <summary>
    /// 出生日期
    /// </summary>
    public DateTime Birthday { get; set; }

    /// <summary>
    /// 生理性別
    /// </summary>
    [Required]
    [DefaultValue(0)]
    public Sex Sex { get; set; }

    /// <summary>
    /// 暱稱
    /// </summary>
    [MaxLength(20)]
    public string NickName { get; set; }

    /// <summary>
    /// 行動電話號碼
    /// </summary>
    [MaxLength(20)]
    public string Mobile { get; set; }

    /// <summary>
    /// 電子信箱
    /// </summary>
    [MaxLength(50)]
    public string Email { get; set; }

    /// <summary>
    /// LINE ID
    /// </summary>
    [MaxLength(50)]
    public string LineId { get; set; }

    #region 調查資料

    /// <summary>
    /// 就診院所
    /// </summary>
    public string Hospital { get; set; }

    /// <summary>
    /// 性行為的對象性別
    /// </summary>
    public string Sexual { get; set; }

    /// <summary>
    /// 居住縣市
    /// </summary>
    public string County { get; set; }

    /// <summary>
    /// 教育程度
    /// </summary>
    public string Education { get; set; }

    /// <summary>
    /// 職業狀況
    /// </summary>
    public string Career { get; set; }

    /// <summary>
    /// 月收入範圍
    /// </summary>
    public string Income { get; set; }

    #endregion

    /// <summary>
    /// 建立日期
    /// </summary>
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 最後修改日期
    /// </summary>
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
    public DateTime UpdatedAt { get; set; }
  }
}
