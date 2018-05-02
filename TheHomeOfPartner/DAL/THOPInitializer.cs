using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheHomeOfPartner.Models;

namespace TheHomeOfPartner.DAL
{
    public class THOPInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<THOPContext>
    {
        protected override void Seed(THOPContext context)
        {
            var Users = new List<User>
            {
                new User{PhotoUrl="../Images/authors/1.png",UserLabel="C#程序猿",UserName="刘大伟",UserSex="男",UserPassWord="zaq123456",PasswordPalt="zaq123456",PhoneNumber="13844123654",UserType="开发人员",RegisterDate=DateTime.Now.Date },
                new User{PhotoUrl="../Images/authors/2.png",UserLabel="威利斯商人",UserName="李旺加",UserSex="男",UserPassWord="zaq123456",PasswordPalt="zaq123456",PhoneNumber="13844123654",UserType="客户",RegisterDate=DateTime.Now.Date},
                new User{PhotoUrl="../Images/authors/3.png",UserLabel="用设计师的眼睛看世界",UserName="田一梅",UserSex="女",UserPassWord="zaq123456",PasswordPalt="zaq123456",PhoneNumber="13844123654",UserType="开发人员",RegisterDate=DateTime.Now.Date},
                new User{PhotoUrl="../Images/authors/4.png",UserLabel="创客",UserName="蔡鹏",UserSex="男",UserPassWord="zaq123456",PasswordPalt="zaq123456",PhoneNumber="13844123654",UserType="客户",RegisterDate=DateTime.Now.Date},
                new User{PhotoUrl="../Images/authors/5.png",UserLabel="美得一塌糊涂",UserName="李美丽",UserSex="女",UserPassWord="zaq123456",PasswordPalt="zaq123456",PhoneNumber="13844123654",UserType="客服",RegisterDate=DateTime.Now.Date},
                new User{PhotoUrl="../Images/authors/6.png",UserLabel="微服务",UserName="刘立",UserSex="男",UserPassWord="zaq123456",PasswordPalt="zaq123456",PhoneNumber="13844123654",UserType="客户",RegisterDate=DateTime.Now.Date},
                new User{PhotoUrl="../Images/authors/7.png",UserLabel="PHP天下第一",UserName="李晓龙",UserSex="男",UserPassWord="zaq123456",PasswordPalt="zaq123456",PhoneNumber="13844123654",UserType="开发人员",RegisterDate=DateTime.Now.Date},
                new User{PhotoUrl="../Images/authors/8.png",UserLabel="手心手背",UserName="黛安安",UserSex="女",UserPassWord="zaq123456",PasswordPalt="zaq123456",PhoneNumber="13844123654",UserType="客户",RegisterDate=DateTime.Now.Date},
                new User{PhotoUrl="../Images/authors/2.png",UserLabel="不能做一辈子的码农",UserName="马文斌",UserSex="男",UserPassWord="zaq123456",PasswordPalt="zaq123456",PhoneNumber="13844123654",UserType="开发人员",RegisterDate=DateTime.Now.Date},
                new User{PhotoUrl="../Images/authors/1.png",UserLabel="顾客就是上帝",UserName="郑莉莉",UserSex="女",UserPassWord="zaq123456",PasswordPalt="zaq123456",PhoneNumber="13844123654",UserType="客户",RegisterDate=DateTime.Now.Date}
            };
            Users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();

            var Topics = new List<Topic>
            {
                new Topic {UserId=6, Title="格林深瞳那些事",Content="北京格灵深瞳信息技术有限公司是一家同时具备计算机视觉和深度学习技术以及嵌入式硬件研发能力的人工智能公司，作为一家视频大数据产品和方案提供商，自主研发的深瞳技术在人和车的检测、跟踪与识别方面居于世界领先水平，公司主要关注的领域包括公共安全、智能交通、金融安防等，同时公司在无人驾驶、机器人和智能医疗方面也进行了深入的布局。",PictureURL="../Images/deepgelin.png",KeyWord="人工智能|计算机视觉|深度学习",ReleaseDate=DateTime.Now},
                new Topic {UserId=2,Title="微软云端你了解多少",Content="Azure 免费帐户包含可免费使用 12 个月或始终免费使用的产品。前 30 天，它还包括 $200 的信用额度，作为一种支出限制，也就是说在前 30 天内，如果产品的使用超出免费产品和数量覆盖范围，则从 $200 信用额度中扣除相应费用。在此信用额度用完之前，不会对信用卡收费。$200 的信用额度一旦用完或 30 天到期后，需要将帐户升级到即用即付 Azure 订阅并移除支出限制，以便能够继续访问帐户中包含的所有免费产品。但现在如果使用的产品及数量超出免费产品和数量覆盖范围，将对信用卡收取相应费用。",PictureURL="../Images/weiruan.png",KeyWord="微软云|服务器|云部署",ReleaseDate=DateTime.Now},
                new Topic {UserId=3,Title="阿里云求教",Content="最近想在阿里买个云服务器，但是上了阿里官网发现内容太多，怕出错，有经验的创友们能不能给点指导！",PictureURL="../Images/ali.png",KeyWord="云端|云解析|域名",ReleaseDate=DateTime.Now},
                new Topic {UserId=1,Title="C#开发语言，你了解吗",Content="C#是微软公司发布的一种面向对象的、运行于.NET Framework之上的高级程序设计语言。并定于在微软职业开发者论坛(PDC)上登台亮相。C#是微软公司研究员Anders Hejlsberg的最新成果。C#看起来与Java有着惊人的相似；它包括了诸如单一继承、接口、与Java几乎同样的语法和编译成中间代码再运行的过程。但是C#与Java有着明显的不同，它借鉴了Delphi的一个特点，与COM（组件对象模型）是直接集成的，而且它是微软公司 .NET windows网络框架的主角。",PictureURL="../Images/suoluetu.svg",KeyWord="C#|开发语言",ReleaseDate=DateTime.Now},
                new Topic {UserId=7,Title="大数据是什么鬼",Content="大数据（big data），指无法在一定时间范围内用常规软件工具进行捕捉、管理和处理的数据集合，是需要新处理模式才能具有更强的决策力、洞察发现力和流程优化能力的海量、高增长率和多样化的信息资产。",PictureURL="../Images/suoluetu.svg",KeyWord="大数据",ReleaseDate=DateTime.Now},
                new Topic {UserId=4,Title="人工智能，我也了解不透",Content="人工智能（Artificial Intelligence），英文缩写为AI。它是研究、开发用于模拟、延伸和扩展人的智能的理论、方法、技术及应用系统的一门新的技术科学。",PictureURL="../Images/suoluetu.svg",KeyWord="人工智能|热门行业",ReleaseDate=DateTime.Now},
                new Topic {UserId=5,Title="格林深瞳那些事",Content="北京格灵深瞳信息技术有限公司是一家同时具备计算机视觉和深度学习技术以及嵌入式硬件研发能力的人工智能公司",PictureURL="../Images/suoluetu.svg",KeyWord="Java",ReleaseDate=DateTime.Now},
                new Topic {UserId=8,Title="格林深瞳那些事",Content="北京格灵深瞳信息技术有限公司是一家同时具备计算机视觉和深度学习技术以及嵌入式硬件研发能力的人工智能公司",PictureURL="../Images/suoluetu.svg",KeyWord="PHP",ReleaseDate=DateTime.Now},
                new Topic {UserId=9,Title="格林深瞳那些事",Content="北京格灵深瞳信息技术有限公司是一家同时具备计算机视觉和深度学习技术以及嵌入式硬件研发能力的人工智能公司",PictureURL="../Images/suoluetu.svg",KeyWord="Python",ReleaseDate=DateTime.Now},
                new Topic {UserId=10,Title="格林深瞳那些事",Content="北京格灵深瞳信息技术有限公司是一家同时具备计算机视觉和深度学习技术以及嵌入式硬件研发能力的人工智能公司",PictureURL="../Images/suoluetu.svg",KeyWord="Android",ReleaseDate=DateTime.Now}
            };
            Topics.ForEach(t => context.Topics.Add(t));
            context.SaveChanges();

            var Replies = new List<Reply>
            {
                new Reply{ UserId = 1, TopicId = 1, ReContent ="牛人的天堂，听说有好多牛人",Approval=false,ReplyDate=DateTime.Now},
                new Reply{ UserId = 2, TopicId = 1, ReContent ="厉害了，格林。看来一下近期发布的产品，技术真强",Approval=false,ReplyDate=DateTime.Now},
                new Reply{ UserId = 3, TopicId = 1, ReContent ="图像处理真不错，得好好学数学，，好好学算法了",Approval=false,ReplyDate=DateTime.Now},
                new Reply{ UserId = 4, TopicId = 1, ReContent ="人脸识别技术也太强了，还有行为分析，厉害，厉害",Approval=false,ReplyDate=DateTime.Now},
                new Reply{ UserId = 5, TopicId = 3, ReContent ="多看看阿里云大学，有入门教程，跟着做就对了",Approval=false,ReplyDate=DateTime.Now},
                new Reply{ UserId = 6, TopicId = 5, ReContent ="牛人的天堂",Approval=false,ReplyDate=DateTime.Now},
                new Reply{ UserId = 7, TopicId = 8, ReContent ="厉害了，格林",Approval=false,ReplyDate=DateTime.Now},
                new Reply{ UserId = 8, TopicId = 4, ReContent ="我也学C#的，多多指教",Approval=false,ReplyDate=DateTime.Now},
                new Reply{ UserId = 9, TopicId = 6, ReContent ="人脸识别太强了",Approval=false,ReplyDate=DateTime.Now},
                new Reply{ UserId = 10,TopicId=7,   ReContent="靠谱吗",Approval=false,ReplyDate=DateTime.Now},
                new Reply{ UserId = 10,TopicId=9,   ReContent="靠谱吗",Approval=false,ReplyDate=DateTime.Now},
                new Reply{ UserId = 10,TopicId=10,   ReContent="靠谱吗",Approval=false,ReplyDate=DateTime.Now},
                new Reply{ UserId = 10,TopicId=2,   ReContent="用过一个月微软云，现在用的是阿里云，感觉微软云还是挺快的",Approval=false,ReplyDate=DateTime.Now},
            };
            Replies.ForEach(r => context.Replies.Add(r));
            context.SaveChanges();

            var Projects = new List<Project>
            {
                new Project{PName="微软中国官网",ProjectRequirement="微软中国是美国微软公司在中国设立的分公司，1992年进入中国设立北京代表处以来，已形成以北京为总部、在上海、广州、武汉、深圳设有分公司的架构。微软在中国也已经跨越了三大发展阶段。从1992年至1995年是微软在中国发展的第一阶段。",ProjectType="Web",DevelopLanguage="C#",Completion="未接单",Price=1000,ReleaseDate=DateTime.Parse("2005-09-01").Date},
                new Project{PName="创友之家网站",ProjectRequirement="微软中国是美国微软公司在中国设立的分公司，1992年进入中国设立北京代表处以来，已形成以北京为总部、在上海、广州、武汉、深圳设有分公司的架构。微软在中国也已经跨越了三大发展阶段。从1992年至1995年是微软在中国发展的第一阶段。",ProjectType="Web",DevelopLanguage="C#",Completion="未接单",Price=1000,ReleaseDate=DateTime.Parse("2005-09-01").Date},
                new Project{PName="腾讯视频客户端",ProjectRequirement="微软中国是美国微软公司在中国设立的分公司，1992年进入中国设立北京代表处以来，已形成以北京为总部、在上海、广州、武汉、深圳设有分公司的架构。微软在中国也已经跨越了三大发展阶段。从1992年至1995年是微软在中国发展的第一阶段。",ProjectType="Android APP",DevelopLanguage="Android",Completion="未接单",Price=1000,ReleaseDate=DateTime.Parse("2005-09-01").Date},
                new Project{PName="网易客户端",ProjectRequirement="微软中国是美国微软公司在中国设立的分公司，1992年进入中国设立北京代表处以来，已形成以北京为总部、在上海、广州、武汉、深圳设有分公司的架构。微软在中国也已经跨越了三大发展阶段。从1992年至1995年是微软在中国发展的第一阶段。",DevelopLanguage="C#",Completion="未接单",Price=1000,ReleaseDate=DateTime.Parse("2005-09-01").Date},
                new Project{PName="人事处网站",ProjectRequirement="微软中国是美国微软公司在中国设立的分公司，1992年进入中国设立北京代表处以来，已形成以北京为总部、在上海、广州、武汉、深圳设有分公司的架构。微软在中国也已经跨越了三大发展阶段。从1992年至1995年是微软在中国发展的第一阶段。",ProjectType="Web",DevelopLanguage="PHP",Completion="未接单",Price=1000,ReleaseDate=DateTime.Parse("2005-09-01").Date},
                new Project{PName="创新创业网站",ProjectRequirement="微软中国是美国微软公司在中国设立的分公司，1992年进入中国设立北京代表处以来，已形成以北京为总部、在上海、广州、武汉、深圳设有分公司的架构。微软在中国也已经跨越了三大发展阶段。从1992年至1995年是微软在中国发展的第一阶段。",ProjectType="Web",DevelopLanguage="PHP",Completion="未接单",Price=1000,ReleaseDate=DateTime.Parse("2005-09-01").Date},
                new Project{PName="未来之星安卓APP",ProjectRequirement="微软中国是美国微软公司在中国设立的分公司，1992年进入中国设立北京代表处以来，已形成以北京为总部、在上海、广州、武汉、深圳设有分公司的架构。微软在中国也已经跨越了三大发展阶段。从1992年至1995年是微软在中国发展的第一阶段。",ProjectType="Web",DevelopLanguage="Android",Completion="未接单",Price=1000,ReleaseDate=DateTime.Parse("2005-09-01").Date},
                new Project{PName="闪亮中国数据挖掘",ProjectRequirement="微软中国是美国微软公司在中国设立的分公司，1992年进入中国设立北京代表处以来，已形成以北京为总部、在上海、广州、武汉、深圳设有分公司的架构。微软在中国也已经跨越了三大发展阶段。从1992年至1995年是微软在中国发展的第一阶段。",ProjectType="Web",DevelopLanguage="python",Completion="未接单",Price=1000,ReleaseDate=DateTime.Parse("2005-09-01").Date},
                new Project{PName="华语广播客户端",ProjectRequirement="微软中国是美国微软公司在中国设立的分公司，1992年进入中国设立北京代表处以来，已形成以北京为总部、在上海、广州、武汉、深圳设有分公司的架构。微软在中国也已经跨越了三大发展阶段。从1992年至1995年是微软在中国发展的第一阶段。",ProjectType="Android APP",DevelopLanguage="C#",Completion="未接单",Price=1000,ReleaseDate=DateTime.Parse("2005-09-01").Date},
                new Project{PName="世纪互联网站",ProjectRequirement="微软中国是美国微软公司在中国设立的分公司，1992年进入中国设立北京代表处以来，已形成以北京为总部、在上海、广州、武汉、深圳设有分公司的架构。微软在中国也已经跨越了三大发展阶段。从1992年至1995年是微软在中国发展的第一阶段。",ProjectType="Web",DevelopLanguage="PHP",Completion="未接单",Price=1000,ReleaseDate=DateTime.Parse("2005-09-01").Date}
            };
            Projects.ForEach(p => context.Projects.Add(p));
            context.SaveChanges();

            var Teams = new List<Team>
            {
                new Team{TeamName="C#开发团队",SkillsRequirement="微软中国是美国微软公司在中国设立的分公司，1992年进入中国设立北京代表处以来，已形成以北京为总部、在上海、广州、武汉、深圳设有分公司的架构。微软在中国也已经跨越了三大发展阶段。从1992年至1995年是微软在中国发展的第一阶段。",RequiredNumber=10,ReleaseDate=DateTime.Now.Date,DueDate=DateTime.Parse("2018-09-01").Date},
                new Team{TeamName="Java开发",SkillsRequirement="微软中国是美国微软公司在中国设立的分公司，1992年进入中国设立北京代表处以来，已形成以北京为总部、在上海、广州、武汉、深圳设有分公司的架构。微软在中国也已经跨越了三大发展阶段。从1992年至1995年是微软在中国发展的第一阶段。",RequiredNumber=10,ReleaseDate=DateTime.Now.Date,DueDate=DateTime.Parse("2018-09-01").Date},
                new Team{TeamName="创友之家项目组队",SkillsRequirement="微软中国是美国微软公司在中国设立的分公司，1992年进入中国设立北京代表处以来，已形成以北京为总部、在上海、广州、武汉、深圳设有分公司的架构。微软在中国也已经跨越了三大发展阶段。从1992年至1995年是微软在中国发展的第一阶段。",RequiredNumber=10,ReleaseDate=DateTime.Now.Date,DueDate=DateTime.Parse("2018-09-01").Date},
                new Team{TeamName="Android开发",SkillsRequirement="微软中国是美国微软公司在中国设立的分公司，1992年进入中国设立北京代表处以来，已形成以北京为总部、在上海、广州、武汉、深圳设有分公司的架构。微软在中国也已经跨越了三大发展阶段。从1992年至1995年是微软在中国发展的第一阶段。",RequiredNumber=10,ReleaseDate=DateTime.Now.Date,DueDate=DateTime.Parse("2018-09-01").Date},
                new Team{TeamName="PHP网站开发",SkillsRequirement="微软中国是美国微软公司在中国设立的分公司，1992年进入中国设立北京代表处以来，已形成以北京为总部、在上海、广州、武汉、深圳设有分公司的架构。微软在中国也已经跨越了三大发展阶段。从1992年至1995年是微软在中国发展的第一阶段。",RequiredNumber=10,ReleaseDate=DateTime.Now.Date,DueDate=DateTime.Parse("2018-09-01").Date},
                new Team{TeamName="python爬虫",SkillsRequirement="微软中国是美国微软公司在中国设立的分公司，1992年进入中国设立北京代表处以来，已形成以北京为总部、在上海、广州、武汉、深圳设有分公司的架构。微软在中国也已经跨越了三大发展阶段。从1992年至1995年是微软在中国发展的第一阶段。",RequiredNumber=10,ReleaseDate=DateTime.Now.Date,DueDate=DateTime.Parse("2018-09-01").Date},
                new Team{TeamName="C#客户端开发",SkillsRequirement="微软中国是美国微软公司在中国设立的分公司，1992年进入中国设立北京代表处以来，已形成以北京为总部、在上海、广州、武汉、深圳设有分公司的架构。微软在中国也已经跨越了三大发展阶段。从1992年至1995年是微软在中国发展的第一阶段。",RequiredNumber=10,ReleaseDate=DateTime.Now.Date,DueDate=DateTime.Parse("2018-09-01").Date},
                new Team{TeamName="ios开发团队",SkillsRequirement="微软中国是美国微软公司在中国设立的分公司，1992年进入中国设立北京代表处以来，已形成以北京为总部、在上海、广州、武汉、深圳设有分公司的架构。微软在中国也已经跨越了三大发展阶段。从1992年至1995年是微软在中国发展的第一阶段。",RequiredNumber=10,ReleaseDate=DateTime.Now.Date,DueDate=DateTime.Parse("2018-09-01").Date},
                new Team{TeamName="北京世纪互联网站开发",SkillsRequirement="微软中国是美国微软公司在中国设立的分公司，1992年进入中国设立北京代表处以来，已形成以北京为总部、在上海、广州、武汉、深圳设有分公司的架构。微软在中国也已经跨越了三大发展阶段。从1992年至1995年是微软在中国发展的第一阶段。",RequiredNumber=10,ReleaseDate=DateTime.Now.Date,DueDate=DateTime.Parse("2018-09-01").Date},
                new Team{TeamName="急需前端设计师",SkillsRequirement="微软中国是美国微软公司在中国设立的分公司，1992年进入中国设立北京代表处以来，已形成以北京为总部、在上海、广州、武汉、深圳设有分公司的架构。微软在中国也已经跨越了三大发展阶段。从1992年至1995年是微软在中国发展的第一阶段。",RequiredNumber=10,ReleaseDate=DateTime.Now.Date,DueDate=DateTime.Parse("2018-09-01").Date}
            };
            Teams.ForEach(t => context.Teams.Add(t));
            context.SaveChanges();

            var ReachAgreements = new List<ReachAgreement>
            {
                new ReachAgreement{UserId=1,ProjectId=1,TeamId=1,AgreementPrice=500,ProjectPictureURL="../Images/weiruan.png",StartDate=DateTime.Parse("2017-09-01").Date,EndDate=DateTime.Parse("2018-09-01").Date,Approval=1000,PageViews=10000},
                new ReachAgreement{UserId=1,ProjectId=2,TeamId=3,AgreementPrice=500,ProjectPictureURL="../Images/cyzj.png",StartDate=DateTime.Parse("2017-09-01").Date,EndDate=DateTime.Parse("2018-09-01").Date,Approval=1000,PageViews=1000},
                new ReachAgreement{UserId=1,ProjectId=3,TeamId=5,AgreementPrice=500,ProjectPictureURL="../Images/p1.jpg",StartDate=DateTime.Parse("2017-09-01").Date,EndDate=DateTime.Parse("2018-09-01").Date,Approval=1000,PageViews=100},
                new ReachAgreement{UserId=1,ProjectId=4,TeamId=7,AgreementPrice=500,ProjectPictureURL="../Images/p1.jpg",StartDate=DateTime.Parse("2017-09-01").Date,EndDate=DateTime.Parse("2018-09-01").Date,Approval=1000,PageViews=10},
                new ReachAgreement{UserId=1,ProjectId=5,TeamId=9,AgreementPrice=500,ProjectPictureURL="../Images/p1.jpg",StartDate=DateTime.Parse("2017-09-01").Date,EndDate=DateTime.Parse("2018-09-01").Date,Approval=1000,PageViews=10},
                new ReachAgreement{UserId=1,ProjectId=6,TeamId=2,AgreementPrice=500,ProjectPictureURL="../Images/p1.jpg",StartDate=DateTime.Parse("2017-09-01").Date,EndDate=DateTime.Parse("2018-09-01").Date,Approval=1000,PageViews=9},
                new ReachAgreement{UserId=1,ProjectId=7,TeamId=4,AgreementPrice=500,ProjectPictureURL="../Images/p1.jpg",StartDate=DateTime.Parse("2017-09-01").Date,EndDate=DateTime.Parse("2018-09-01").Date,Approval=1000,PageViews=6},
                new ReachAgreement{UserId=1,ProjectId=8,TeamId=6,AgreementPrice=500,ProjectPictureURL="../Images/p1.jpg",StartDate=DateTime.Parse("2017-09-01").Date,EndDate=DateTime.Parse("2018-09-01").Date,Approval=1000,PageViews=2},
                new ReachAgreement{UserId=1,ProjectId=9,TeamId=8,AgreementPrice=500,ProjectPictureURL="../Images/p1.jpg",StartDate=DateTime.Parse("2017-09-01").Date,EndDate=DateTime.Parse("2018-09-01").Date,Approval=1000,PageViews=3},
                new ReachAgreement{UserId=1,ProjectId=10,TeamId=10,AgreementPrice=500,ProjectPictureURL="../Images/p1.jpg",StartDate=DateTime.Parse("2017-09-01").Date,EndDate=DateTime.Parse("2018-09-01").Date,Approval=1000,PageViews=8},
            };
            ReachAgreements.ForEach(r => context.ReachAgreements.Add(r));
            context.SaveChanges();

            var ChatLogs = new List<ChatLog>
            {
                new ChatLog {UserId=2,UserName="李旺加",ChatContent="你好，在吗？",ChatTime=DateTime.Now,UserType="客户"},
                new ChatLog {UserId=1,UserName="刘大伟",ChatContent="在的亲，有什么具体要求？",ChatTime=DateTime.Now,UserType="开发人员"},
                new ChatLog {UserId=1,UserName="刘大伟",ChatContent="有什么具体要求？",ChatTime=DateTime.Now,UserType="开发人员"},
                new ChatLog {UserId=5,UserName="李美丽",ChatContent="你们先聊，有问题找我！",ChatTime=DateTime.Now,UserType="客服"},
                new ChatLog {UserId=2,UserName="李旺加",ChatContent="我们需要做个网站，大概内容就是发布的情况，我想说一下细节",ChatTime=DateTime.Now,UserType="客户"},
                new ChatLog {UserId=1,UserName="刘大伟",ChatContent="您请说",ChatTime=DateTime.Now,UserType="开发人员"},
                new ChatLog {UserId=2,UserName="李旺加",ChatContent="数据报表不要做柱状图，领导不喜欢",ChatTime=DateTime.Now,UserType="客户"},
                new ChatLog {UserId=1,UserName="刘大伟",ChatContent="那没问题，其他还有什么需要注意的？",ChatTime=DateTime.Now,UserType="开发人员"},
                new ChatLog {UserId=2,UserName="李旺加",ChatContent="那个价格能接受吗，不够可以加点儿",ChatTime=DateTime.Now,UserType="客户"},
                new ChatLog {UserId=1,UserName="刘大伟",ChatContent="够了，谢谢。我们按工作量算价格",ChatTime=DateTime.Now,UserType="开发人员"}
            };
            ChatLogs.ForEach(c=> context.ChatLogs.Add(c));
            context.SaveChanges();
        }
    }
}