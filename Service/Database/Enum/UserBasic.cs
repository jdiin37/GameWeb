using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Database.Enum
{
  
  /// <summary>
  /// 角色狀態
  /// </summary>
  public enum Status
  {
    /// <summary>
    /// 未啟用
    /// </summary>
    Unverified = 0,
    /// <summary>
    /// 啟用
    /// </summary>
    Enable = 1,
    /// <summary>
    /// 封鎖
    /// </summary>
    Block = 2,
    /// <summary>
    /// 刪除
    /// </summary>
    Delete = 3
  }

  /// <summary>
  /// 角色權限
  /// </summary>
  public enum Role
  {
    /// <summary>
    /// 一般使用者
    /// </summary>
    Member = 0,
    /// <summary>
    /// 系統管理者
    /// </summary>
    SysAdmin = 1,
    /// <summary>
    /// 後台管理者
    /// </summary>
    BackAdmin = 2,
  }

  /// <summary>
  /// 生理性別
  /// </summary>
  public enum Sex
  {
    /// <summary>
    /// 未知
    /// </summary>
    Unknown = 0,
    /// <summary>
    /// 男性
    /// </summary>
    Male = 1,
    /// <summary>
    /// 女性
    /// </summary>
    Female = 2,
    /// <summary>
    /// 其他
    /// </summary>
    Other = 3
  }
  
}
