using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using TheHomeOfPartner.Models;

namespace TheHomeOfPartner.DAL
{
    public class THOPContext: DbContext
    {
        public THOPContext(): base("THOPContext")//指定的连接字符串，名称为“THOPContext”，在Webconfig中配置
        {

        }

        public DbSet<User> Users { get; set; }//用户ID
        public DbSet<Project> Projects { get; set; }//项目表
        public DbSet<Team> Teams { get; set; }//团队表
        public DbSet<ReachAgreement> ReachAgreements { get; set; }//完成的项目记录表
        public DbSet<Topic> Topics { get; set; }//论坛话题信息表
        public DbSet<Reply> Replies { get; set; }//论坛评论信息表
        public DbSet<ChatLog> ChatLogs { get; set; }//聊天消息记录表

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//指定采用单数形式的表名称，即DbSet<Project>在数据库中的表名仍为Project，而不是Projects
        }
    }
}