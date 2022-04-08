using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderWireCodingChallenge.Tests.Model
{
    public static class Constants
    {
        public static string Article = "This is what I learned from Mr. Jones about a paragraph. A paragraph is a group of words put together to form a group that is usually longer than a sentence. Paragraphs are often made up of several sentences. There are usually between three and eight sentences. Paragraphs can begin with an indentation, or by missing a line out, and then starting again. This makes it easier to see when one paragraph ends and another begins. In most organized forms of writing, such as essays, paragraphs contain a topic sentence. This topic sentence of the paragraph tells the reader what the paragraph will be about. Essays usually have multiple paragraphs that make claims to support a thesis statement, which is the central idea of the essay. Paragraphs may signal when the writer changes topics. Each paragraph may have a number of sentences, depending on the topic. I can now write topics on sports e.g. basketball, football, baseball and submit it to Mrs. Smith.";

        /// <summary>
        /// Comma delimitted for testing only. comes from Word.txt
        /// </summary>
        public static string Word = "this,is,what,i,learned,from,mr.,jones,about,a,paragraph,group,of,words,put,together,to,form,that,usually,longer,than,sentence,paragraphs,are,often,made,up,several,sentences,there,between,three,and,eight,can,begin,with,an,indentation,or,by,missing,line,out,then,starting,again,makes,it,easier,see,when,one,ends,another,begins,in,most,organized,forms,writing,such,as,essays,contain,topic,the,tells,reader,will,be,have,multiple,make,claims,support,thesis,statement,which,central,idea,essay,may,signal,writer,changes,topics,each,number,depending,on,now,write,sports,e.g.,basketball,football,baseball,submit,mrs.,smith";

        /// <summary>
        /// Pipe delimitted for testing only, comes from the Output.txt
        /// </summary>
        public static string WordOutput = "a. this {3:1,6,8}| b. is {4:1,2,2,9}| c. what {2:1,8}| d. i {2:1,12}| e. learned {1:1}| f. from {1:1}| g. mr. {1:1}| h. jones {1:1}| i. about {2:1,8}| j. a {9:1,2,2,2,2,5,7,9,11}| k. paragraph {6:1,2,6,8,8,11}| l. group {2:2,2}| m. of {6:2,3,7,8,9,11}| n. words {1:2}| o. put {1:2}| p. together {1:2}| q. to {4:2,6,9,12}| r. form {1:2}| s. that {2:2,9}| t. usually {3:2,4,9}| u. longer {1:2}| v. than {1:2}| w. sentence {3:2,7,8}| x. paragraphs {5:3,5,7,9,10}| y. are {2:3,4}| z. often {1:3}| aa. made {1:3}| bb. up {1:3}| cc. several {1:3}| dd. sentences {3:3,4,11}| ee. there {1:4}| ff. between {1:4}| gg. three {1:4}| hh. and {4:4,5,6,12}| ii. eight {1:4}| jj. can {2:5,12}| kk. begin {1:5}| ll. with {1:5}| mm. an {1:5}| nn. indentation {1:5}| oo. or {1:5}| pp. by {1:5}| qq. missing {1:5}| rr. line {1:5}| ss. out {1:5}| tt. then {1:5}| uu. starting {1:5}| vv. again {1:5}| ww. makes {1:6}| xx. it {2:6,12}| yy. easier {1:6}| zz. see {1:6}| aaa. when {2:6,10}| bbb. one {1:6}| ccc. ends {1:6}| ddd. another {1:6}| eee. begins {1:6}| fff. in {1:7}| ggg. most {1:7}| hhh. organized {1:7}| iii. forms {1:7}| jjj. writing {1:7}| kkk. such {1:7}| lll. as {1:7}| mmm. essays {2:7,9}| nnn. contain {1:7}| ooo. topic {3:7,8,11}| ppp. the {7:8,8,8,9,9,10,11}| qqq. tells {1:8}| rrr. reader {1:8}| sss. will {1:8}| ttt. be {1:8}| uuu. have {2:9,11}| vvv. multiple {1:9}| www. make {1:9}| xxx. claims {1:9}| yyy. support {1:9}| zzz. thesis {1:9}| aaaa. statement {1:9}| bbbb. which {1:9}| cccc. central {1:9}| dddd. idea {1:9}| eeee. essay {1:9}| ffff. may {2:10,11}| gggg. signal {1:10}| hhhh. writer {1:10}| iiii. changes {1:10}| jjjj. topics {2:10,12}| kkkk. each {1:11}| llll. number {1:11}| mmmm. depending {1:11}| nnnn. on {2:11,12}| oooo. now {1:12}| pppp. write {1:12}| qqqq. sports {1:12}| rrrr. e.g. {1:12}| ssss. basketball {1:12}| tttt. football {1:12}| uuuu. baseball {1:12}| vvvv. submit {1:12}| wwww. mrs. {1:12}| xxxx. smith {1:12}";
    }
}
