namespace Guestbook.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    using Guestbook.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataContext context)
        {
            context.Messages.AddOrUpdate(m => m.UserName,
                new Message { UserName ="Marianela Kingery", Email ="_ci89xuq0f8r@mspp6-86sx66.com" , Homepage =@"https://www.google.com.ua/" , CreatedAt = DateTime.Now, Text ="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce in scelerisque ex. Sed vel leo ex. Vivamus ut interdum libero, nec consequat tortor. Nam molestie euismod eleifend. Praesent ante est, vulputate id nibh a, accumsan hendrerit nulla. Quisque ante mi, rutrum non orci vel, dapibus molestie nulla. Sed imperdiet ante ex, dapibus tempor felis suscipit sit amet. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nam dignissim, justo non tincidunt dignissim, libero urna venenatis diam, id ultrices sem massa faucibus justo. Nam vitae quam auctor, tristique tortor ut, fringilla quam. Sed lobortis vel augue vel sodales. Curabitur vel tortor eget lacus condimentum scelerisque. Nullam posuere volutpat nibh, quis gravida elit congue id." },
                new Message { UserName = "Tenesha Button", Email = "4v6rt4t3yo@mg5ilyzx.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-1), Text = "Maecenas ultrices tempus dui quis tincidunt. Phasellus blandit odio massa, at tempor tellus ullamcorper vitae. Sed ultrices, mauris auctor aliquam volutpat, felis leo varius nibh, vel fringilla ipsum massa sed magna. Pellentesque ac sapien quis odio fringilla lobortis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; In pulvinar, sem non accumsan pulvinar, eros dolor euismod nibh, quis fermentum quam ligula et mauris. Quisque sit amet turpis cursus, scelerisque nibh at, venenatis lectus. Quisque blandit dapibus urna, at sollicitudin risus accumsan a. Maecenas hendrerit, velit sed lobortis faucibus, ligula nisi pellentesque ante, at mattis diam lorem id orci. Cras iaculis vel nulla eget volutpat. Donec ullamcorper hendrerit tortor sit amet dapibus. Praesent viverra turpis et justo consectetur aliquam. Praesent rutrum efficitur pretium. Morbi ac dolor tortor. Suspendisse sit amet quam arcu." },
                new Message { UserName = "Jacob Failla", Email = "bad-9@vv2pgb.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-2), Text = "Vivamus sed arcu consequat, condimentum ante et, vestibulum felis. Pellentesque tempor sapien a dolor ullamcorper sollicitudin. Duis id dui tincidunt, maximus velit eu, accumsan ipsum. Nullam aliquam neque eget tempus condimentum. Mauris rutrum, eros sit amet convallis sagittis, massa mauris laoreet est, non tincidunt quam est sit amet enim. Suspendisse sed tortor vel tortor venenatis commodo sed tincidunt massa. Sed quis sem feugiat, ultrices velit vel, sodales massa. Pellentesque ut dolor ligula." },
                new Message { UserName = "Jefferey Arn", Email = "7xixd@0irkoktz0hm.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-3), Text = "Nam placerat, risus eu rutrum bibendum, ligula erat feugiat odio, et suscipit erat justo vitae nibh. Nullam vitae aliquet arcu. Sed faucibus neque nulla, non tincidunt enim scelerisque ut. Cras at est nunc. Sed luctus purus urna, nec fermentum urna rhoncus sit amet. Nulla hendrerit finibus enim, ut fermentum metus sollicitudin eget. Etiam quis dolor vel lectus vehicula consequat. Maecenas malesuada mattis justo vel rhoncus. Aliquam et pellentesque sem. Nam pretium, neque id commodo lobortis, velit nisi varius nisl, mattis tincidunt metus ipsum eget dolor. Quisque eget urna dignissim, aliquam ante eu, lacinia eros. Donec bibendum urna quis augue congue, quis accumsan justo sollicitudin. Maecenas vitae arcu sem. Sed accumsan quis tortor eget maximus." },
                new Message { UserName = "Diana Marney", Email = "pfpn@a-82od4t.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-4), Text = "Quisque ut neque ut risus dignissim efficitur. Integer commodo augue id blandit fringilla. Suspendisse lobortis dui ac sem commodo, at eleifend ante tristique. Cras hendrerit sem a molestie faucibus. Aenean tincidunt faucibus lacus, ac tempor velit ultricies id. Morbi egestas finibus ullamcorper. In tempus urna a justo viverra luctus. Quisque auctor augue eget nunc rhoncus, sed tristique magna fringilla." },
                new Message { UserName = "Fernande Midgley", Email = "fbii.r2l7.6v-@b7cmkh2wi1.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-5), Text = "Duis ac eros non urna fermentum tempus in sed mi. In purus libero, bibendum sit amet enim vel, ornare malesuada massa. Nunc mattis dui nec est blandit sodales. Pellentesque id eros at nibh volutpat tincidunt non finibus urna. Sed scelerisque velit odio, vel bibendum ante posuere vitae. Sed feugiat sem euismod, eleifend mauris eget, feugiat urna. Phasellus a velit et tellus fringilla dapibus. Curabitur tristique egestas magna, sed finibus augue egestas at. Cras nulla massa, ultricies non aliquam vitae, lobortis vitae nisl. Donec malesuada tempor est, luctus molestie massa gravida a." },
                new Message { UserName = "Julio Leslie", Email = "ey5zqp5sy@aqcz29yurwvn.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-6), Text = "Phasellus et convallis nunc, in ultrices risus. Curabitur eget purus a est consequat sagittis fringilla non dolor. Sed ex nunc, sodales ut orci viverra, faucibus suscipit nunc. Aliquam varius pharetra ullamcorper. In semper consectetur sem sit amet viverra. Curabitur in augue nisl. Quisque sed arcu at nibh dictum mollis at ut neque." },
                new Message { UserName = "Carolin Wilburn", Email = "y91jeq4euo9@f4k9j891-wr8.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-7), Text = "Donec nunc nunc, eleifend sit amet lorem sit amet, sodales pellentesque arcu. Donec vitae lectus ut justo tincidunt semper. Proin eget accumsan velit. Aenean vulputate efficitur enim at vehicula. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Pellentesque faucibus consequat libero, quis aliquam odio imperdiet ac. Cras quis elit at mauris bibendum euismod sed eget lorem. Morbi a libero sem. Pellentesque eget sapien mauris. Nam porta eleifend metus a congue. Sed a porta sapien, in sagittis turpis. Suspendisse nec est non urna ultricies accumsan id quis mi. Proin faucibus ipsum id mi congue bibendum. Morbi aliquam lectus vel pulvinar egestas. In vel ipsum in erat facilisis tempor a vitae quam." },
                new Message { UserName = "Benjamin Hersom", Email = "o0y3wv@mrjvwy.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-8), Text = "Nulla vitae ipsum interdum augue ullamcorper eleifend. Pellentesque at magna sodales, lobortis lorem id, facilisis sapien. Sed iaculis porttitor arcu ac ultricies. Etiam viverra egestas ligula, et tincidunt libero ornare at. Vivamus a felis posuere, laoreet ipsum quis, molestie felis. Mauris vel velit et diam condimentum imperdiet ut at urna. Vestibulum sit amet odio nec dui imperdiet imperdiet. Vivamus id lectus nec neque rhoncus posuere. Fusce porttitor eget justo at pellentesque. Vestibulum faucibus, ligula sit amet faucibus feugiat, ipsum ante scelerisque sapien, ac efficitur ex est nec elit. Ut sit amet vestibulum dui. Pellentesque vehicula mollis turpis vitae tincidunt. Aenean semper finibus augue quis luctus. Aenean ut ligula in magna dapibus pulvinar ut vel quam. Aliquam venenatis elementum elementum." },
                new Message { UserName = "Darla Priolo", Email = "g3wnu8k@43ht25-xeb.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-9), Text = "Pellentesque ultricies libero eget mauris malesuada, non iaculis tortor accumsan. Nunc non nunc vel sapien lobortis placerat. Fusce tristique porttitor posuere. Duis molestie cursus dolor, quis venenatis mi dictum vitae. Donec sit amet nulla fringilla, placerat lacus et, sagittis justo. Etiam euismod tempus facilisis. Quisque finibus nisi eget eros molestie blandit. Praesent imperdiet eu eros sit amet mattis. Etiam sed mi eu velit pretium bibendum et id lacus. Pellentesque rhoncus vitae nibh eleifend porta. Fusce gravida sem nec molestie facilisis. Nunc sed erat vitae orci varius placerat pharetra quis neque. Duis at eleifend libero. Interdum et malesuada fames ac ante ipsum primis in faucibus." },
                new Message { UserName = "Brigida Hammonds", Email = "z3x@icdryz.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-10), Text = "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Curabitur finibus risus dolor. Interdum et malesuada fames ac ante ipsum primis in faucibus. Suspendisse commodo erat mi, ac bibendum magna aliquet quis. Vivamus non ante pretium, ullamcorper erat quis, fermentum massa. Proin id felis orci. Duis at sollicitudin sapien. Duis suscipit risus ex, luctus tempus augue semper quis. In maximus volutpat eleifend. Ut nec pretium erat, at malesuada erat. Etiam ac finibus odio. Nullam sed consequat elit. Phasellus quis nibh eget elit rutrum pharetra." },
                new Message { UserName = "Annetta Stauber", Email = "pm3_@yj58cv.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-11), Text = "Nam iaculis quis odio eu fringilla. Nam id viverra eros. Morbi in arcu porttitor, imperdiet purus et, congue ligula. Nullam sit amet tellus faucibus, sagittis sem vitae, posuere nulla. Etiam id erat vel est luctus molestie eu sit amet ex. Mauris viverra nec urna eget rutrum. Donec feugiat augue non vehicula pellentesque. Ut rhoncus vulputate erat, ac posuere sapien scelerisque sed. Suspendisse faucibus ultricies justo non interdum. Donec diam justo, luctus eget hendrerit nec, accumsan ac dui. In congue lorem non eleifend mattis." },
                new Message { UserName = "Rebekah Zanders", Email = "m-w_@bw0ckzys32.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-12), Text = "In elementum porta nulla, non faucibus tellus placerat id. Quisque cursus enim orci, tempor lacinia lectus venenatis ac. Etiam vehicula arcu ut aliquet pharetra. Curabitur viverra mi id elit bibendum sollicitudin. Ut mattis lectus vitae varius porttitor. Sed eu consectetur magna, id gravida diam. Donec elementum lorem magna, vitae aliquam nulla fermentum sit amet. Etiam eget auctor turpis. Nunc luctus orci nec fermentum tincidunt. Nunc fermentum vulputate auctor. In in mauris commodo, varius justo ut, volutpat augue. Mauris enim metus, iaculis ac purus in, mattis vulputate metus. Maecenas malesuada blandit orci, nec lacinia urna ullamcorper sed. Aliquam hendrerit facilisis feugiat. In ut accumsan felis." },
                new Message { UserName = "Liana Harsch", Email = "rdq7qg5cqy.sidc@taxsbjret.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-13), Text = "Fusce vel nunc quis erat pulvinar maximus. Maecenas semper placerat erat, eget vehicula sem accumsan sit amet. Maecenas at scelerisque mi, quis finibus turpis. Fusce id sem in orci tincidunt iaculis. Proin facilisis consectetur ante, eget faucibus quam fringilla vel. Nam porttitor interdum dignissim. Donec sit amet ultrices justo, commodo porttitor lectus. Ut finibus hendrerit risus, et condimentum sapien commodo nec. Nam in odio vehicula, condimentum purus nec, interdum magna. Pellentesque turpis elit, ullamcorper ut enim quis, sollicitudin tempor dolor. Duis ornare nisi ac elit ultricies scelerisque. Nunc sed pharetra ipsum. Maecenas quis nibh nec nunc condimentum finibus vitae vel purus. Suspendisse imperdiet metus erat, eu faucibus velit finibus in. Integer vel auctor ligula, sed ultricies orci." },
                new Message { UserName = "Thaddeus Beazley", Email = "a-u.o@0d54s-vuohu.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-14), Text = "Maecenas placerat risus urna, sit amet tincidunt lectus mattis eu. Curabitur elementum sollicitudin est, vel malesuada ipsum scelerisque vitae. Praesent semper egestas scelerisque. Nunc viverra sollicitudin feugiat. Nulla quis blandit felis, at fermentum nunc. Fusce porta magna et turpis feugiat ornare. Fusce mattis leo eros, facilisis mattis lectus ullamcorper eget." },
                new Message { UserName = "Latoya Ippolito", Email = "y0-zvr2606mdxn@bempdpi7.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-15), Text = "Pellentesque posuere ipsum sit amet ultrices posuere. Pellentesque luctus dolor sed purus fringilla, eget tempus urna ultricies. Aliquam erat volutpat. Vestibulum rutrum semper suscipit. Mauris at orci at orci aliquam efficitur. Sed pellentesque orci ac ultrices facilisis. Proin hendrerit ultrices volutpat. Donec elit turpis, facilisis a imperdiet vel, euismod in libero. Nam imperdiet tortor vel risus pretium, at sodales enim rhoncus. Duis lobortis magna consequat libero laoreet, et luctus felis varius. Donec in mattis urna. Cras mi magna, elementum non est non, consectetur ornare dolor. Praesent et nisl eros. Phasellus lacinia accumsan pretium. Fusce nec nisl nunc." },
                new Message { UserName = "Estefana Cayton", Email = "stw1brd1obm0tb2@o6bsqot.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-16), Text = "Quisque mattis pulvinar augue quis aliquam. Proin sapien sapien, venenatis et luctus ut, imperdiet quis nulla. Aliquam eget quam feugiat, mattis sapien vel, euismod purus. Nulla commodo efficitur arcu eu viverra. In cursus metus id leo luctus, sed rutrum nisl volutpat. Nunc suscipit dolor dui. Curabitur id consectetur velit. Cras porta est enim, sed tincidunt neque viverra convallis. Maecenas est orci, interdum vel maximus sed, aliquet id ipsum." },
                new Message { UserName = "Alleen Johnosn", Email = "-zfgvcnbw-@1wo5k27wynx.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-17), Text = "Nam faucibus diam a tellus volutpat dapibus. Vivamus lacinia sed nunc ac porta. Quisque auctor, massa sed bibendum sodales, felis tellus condimentum est, quis fermentum sem purus nec turpis. Pellentesque scelerisque, neque ut vehicula tincidunt, risus felis tincidunt quam, nec porttitor leo elit eget neque. Aliquam et aliquam risus, at mattis lorem. Sed malesuada dui erat, sed placerat nulla tincidunt nec. Nunc vestibulum eros nulla, ac facilisis erat dapibus nec." },
                new Message { UserName = "Lan Moldenhauer", Email = "tqj-64t@tzgz613h3mf.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-18), Text = "Aenean pretium faucibus maximus. Sed erat lectus, scelerisque vel auctor in, porttitor non metus. Vivamus sed diam volutpat, facilisis sem at, faucibus purus. Mauris sodales quam et efficitur porttitor. Integer quam ipsum, feugiat ut elit vitae, fermentum laoreet erat. Proin eu nunc id dui dignissim suscipit. Duis rutrum libero orci, quis egestas mauris bibendum dignissim. Integer quis aliquam orci. Curabitur sapien sem, posuere sit amet blandit ut, facilisis non nisl." },
                new Message { UserName = "Alton Spratt", Email = "vlhlg6_tr@lk92t7ukod-u.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-19), Text = "Nunc id quam ut dui rhoncus interdum non et urna. Integer a dui porttitor, dignissim purus ac, dictum mi. Cras ac gravida purus, at imperdiet nulla. Vivamus enim ex, vulputate ut malesuada id, elementum vitae elit. Pellentesque quis ligula at est egestas maximus. Sed ultricies dolor vel aliquet mattis. Aenean consectetur turpis vitae massa feugiat condimentum. Nullam in nibh in augue porttitor hendrerit nec eu sem." },
                new Message { UserName = "Orval Gladden", Email = "lubc8hu536.b@a4-sil3gbkb.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-20), Text = "Praesent faucibus velit vitae consectetur egestas. Duis diam velit, ultricies sit amet ultrices quis, dignissim ullamcorper enim. Praesent eu congue neque, eget rutrum tortor. Nam pretium ornare interdum. Sed eu pulvinar magna. Vestibulum dignissim hendrerit neque, quis eleifend dolor pulvinar eget. Mauris porttitor leo sit amet nunc bibendum, sit amet iaculis libero faucibus. Aenean et diam nec felis luctus varius sit amet ut nunc. Fusce lobortis ex augue, id aliquam libero tempus non. Suspendisse laoreet purus augue, tincidunt congue ex dignissim sit amet. Cras cursus ligula dolor. Aliquam rutrum sollicitudin mollis. Quisque cursus vitae tortor quis tristique. Vivamus vel varius metus, ac porttitor sapien. Donec diam mauris, ultricies sit amet odio sit amet, condimentum vehicula mauris." },
                new Message { UserName = "Vesta Sunday", Email = "r1varpl_ro@5x7wo1vpzn.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-21), Text = "Aenean mattis lorem felis, et bibendum lectus condimentum luctus. Nulla facilisi. Vestibulum mattis venenatis hendrerit. Suspendisse quis diam efficitur, sodales sapien eu, eleifend enim. Vestibulum ligula lorem, mollis vitae quam non, molestie elementum nisi. Sed at viverra elit, vel vehicula nulla. Donec eget erat in dui mollis rutrum nec nec sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus." },
                new Message { UserName = "Romona Moor", Email = "x2-43i6m@4janjq2.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-22), Text = "Sed dolor sapien, interdum id lorem quis, varius posuere nisl. Nullam vitae ex eget lectus dignissim euismod non id urna. Fusce varius leo at lorem porta sodales. Pellentesque pulvinar eros vitae pellentesque hendrerit. Donec ante nisi, efficitur at ante vel, elementum suscipit orci. Sed in iaculis orci, a ullamcorper lacus. Aliquam maximus ante eget tellus facilisis tincidunt." },
                new Message { UserName = "Marguerita Ellzey", Email = "h-j777iuqy@i3bon1mf.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-23), Text = "Curabitur ultricies maximus odio in dapibus. Mauris auctor vulputate sapien, id imperdiet nisi cursus quis. Maecenas accumsan faucibus turpis, ut mollis nunc tempor ac. Praesent molestie tellus enim, varius imperdiet turpis consectetur sit amet. Integer tincidunt urna tortor, ut sollicitudin enim euismod in. Aenean nec condimentum eros. Donec elementum pulvinar leo, ut ornare nunc tincidunt et. Integer pellentesque vitae mauris ut dapibus. Nunc sed lacus et nunc aliquet fringilla vitae id sapien. Nullam vehicula nisi vel lectus rutrum, ac lobortis felis dapibus." },
                new Message { UserName = "Priscilla Candelario", Email = "_6ni62tjr@cyya8s521.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-24), Text = "Aenean quis viverra felis, sed posuere orci. In aliquam eleifend libero. Ut sed nisi sollicitudin, tempus sapien a, placerat est. Sed finibus volutpat risus vitae cursus. Sed ac commodo lacus, a accumsan quam. Suspendisse malesuada augue odio, a sollicitudin leo dignissim faucibus. Curabitur consequat convallis suscipit. Vestibulum mi risus, lobortis rutrum pulvinar nec, consectetur a dolor. Duis ipsum lorem, auctor et est nec, viverra porta dolor. Aenean commodo ex condimentum molestie ornare." },
                new Message { UserName = "Marcelene Erlandson", Email = "ox-p.me@lqv6poh.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-25), Text = "Sed vel ex at diam luctus cursus. Ut sed cursus turpis. Cras viverra maximus semper. Fusce eu eros dignissim, bibendum mi sit amet, euismod urna. Vestibulum molestie, diam in tincidunt convallis, lectus dolor tincidunt elit, eget pellentesque lorem sem quis ex. Aliquam eget imperdiet felis. Proin at sapien tortor. Curabitur nibh magna, dignissim vitae lobortis sit amet, pellentesque sit amet massa. Nunc at risus quis eros mattis cursus. Sed finibus euismod nulla. Nunc id nulla magna." },
                new Message { UserName = "Deena Olmedo", Email = "0fsnifaibtb@4ip0va8.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-26), Text = "Interdum et malesuada fames ac ante ipsum primis in faucibus. Pellentesque sit amet mauris eleifend mi porta suscipit. Sed consectetur pellentesque odio nec convallis. Mauris porta eget urna et rhoncus. Etiam vel risus vel lorem porttitor porta. Praesent vel dolor lorem. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Sed dui ex, eleifend eu ex a, porttitor congue ex. Praesent sodales, nisl ac condimentum scelerisque, libero magna commodo tortor, in volutpat dolor lacus non leo. Praesent tincidunt lacus quis nisl varius luctus." },
                new Message { UserName = "Dean Paddock", Email = "idl11gddo3lk84x@c7wk9em1m2z8.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-27), Text = "Nulla facilisi. Phasellus eu vestibulum augue, eget sollicitudin orci. Proin scelerisque ligula quis nisl molestie malesuada. Duis et nisl sit amet ex lacinia tempus in vel libero. Vestibulum nec sem posuere, efficitur ex vitae, blandit risus. Suspendisse commodo ut sem eu maximus. Fusce quis mauris lacus." },
                new Message { UserName = "Tatyana Baldwin", Email = "935.br1hu4vk@c5f5qi1bs.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-28), Text = "Aenean eleifend laoreet sem in iaculis. Nullam sagittis neque ac imperdiet pulvinar. Phasellus ut ipsum neque. Integer auctor gravida lorem a vestibulum. Vestibulum tristique volutpat est vel scelerisque. Etiam ultrices eget nunc ut ornare. Donec convallis bibendum eros non eleifend." },
                new Message { UserName = "Yung Atkins", Email = "7otwbqmxlcp@kd50kn1.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-29), Text = "Suspendisse porta viverra elit ut dignissim. Duis mattis magna eros, ac feugiat odio semper vel. Phasellus sagittis pulvinar volutpat. Nulla blandit ante in luctus sodales. In hac habitasse platea dictumst. Phasellus magna dui, placerat eget vehicula in, aliquam ut mauris. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Duis rutrum nulla vitae justo pellentesque, sit amet iaculis dui faucibus. Aenean dapibus suscipit purus et vehicula. Sed nec dictum elit, quis congue ex. Nam iaculis iaculis mauris, eget faucibus erat volutpat vel. Nullam eget risus aliquet, interdum dui non, ultrices urna. Cras aliquet fringilla velit vel hendrerit. Aliquam tempor rutrum justo ut rutrum. Nullam imperdiet augue vitae enim imperdiet, vitae pretium ex finibus. Aliquam eleifend a mauris id tempus." },
                new Message { UserName = "Trisha Abbey", Email = "_ci89xuq0f8r@mspp6-86sx66.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-30), Text = "Nam vel massa eget enim venenatis commodo. Phasellus nisl augue, consectetur et odio non, feugiat semper lectus. Vivamus condimentum rhoncus urna, a cursus velit aliquet condimentum. Phasellus quis purus viverra, cursus orci in, dapibus odio. Nam iaculis sed turpis vitae blandit. Etiam a interdum dui, at blandit ante. Nullam pellentesque dictum diam et laoreet. Nulla hendrerit suscipit magna vitae fermentum. Vivamus finibus, orci finibus maximus consequat, justo risus mollis elit, quis elementum augue purus eget odio." },
                new Message { UserName = "Randal Harting", Email = "4v6rt4t3yo@mg5ilyzx.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-31), Text = "Vestibulum lobortis non ligula sit amet vestibulum. Praesent nec arcu eu dolor semper posuere iaculis a tortor. Sed imperdiet efficitur erat vitae ullamcorper. Vestibulum tincidunt, neque vitae congue pulvinar, purus massa venenatis nulla, quis sagittis lectus ligula et risus. Mauris vulputate lectus et libero venenatis dignissim. Nulla at odio et diam pharetra fringilla in et sem. Fusce mi lorem, lacinia nec elit a, ultricies pharetra augue. Nulla sagittis lacus eros. Cras non odio tristique, malesuada ante sit amet, dapibus felis. Aenean dictum mattis diam eu blandit. Sed at tortor libero. Sed volutpat, quam sed mollis luctus, urna tellus elementum nisl, vel consectetur sem est eu mi. Pellentesque sed malesuada ipsum, vel semper eros." },
                new Message { UserName = "Elsy Cecere", Email = "bad-9@vv2pgb.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-32), Text = "Vestibulum iaculis lacinia ex ac tincidunt. Maecenas nec enim non libero luctus viverra. Fusce at viverra tortor. Cras imperdiet sem nisl, et pretium sem aliquam at. Morbi rhoncus nisi odio, at ornare ante porta sed. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer sed lacus id ligula sollicitudin aliquam. Vestibulum aliquam iaculis orci ut vulputate. Nullam commodo augue ante, eu varius felis cursus eget. Proin non dui non lorem rhoncus posuere. Sed consectetur leo ac nunc dignissim, vitae molestie eros faucibus. Ut nec turpis diam. Vestibulum eu ante facilisis libero volutpat auctor at eget eros. Cras iaculis odio eget purus mollis, a commodo ante pretium. Vivamus tempor fringilla nibh." },
                new Message { UserName = "Adolfo Seevers", Email = "7xixd@0irkoktz0hm.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-33), Text = "Donec eu turpis nisl. Ut consequat diam in tortor auctor, eget lacinia felis iaculis. Interdum et malesuada fames ac ante ipsum primis in faucibus. Pellentesque eu varius erat. Nulla vitae lorem porta, ullamcorper est non, viverra orci. Proin ac erat at diam lobortis dictum nec bibendum diam. Nulla velit eros, fermentum a quam tristique, fringilla tincidunt metus. Cras tortor neque, scelerisque in scelerisque in, consectetur quis est. Cras venenatis metus et augue iaculis dapibus. In vel gravida dolor." },
                new Message { UserName = "Lavern Pringle", Email = "pfpn@a-82od4t.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-34), Text = "Pellentesque et venenatis leo, nec sagittis eros. Vivamus elementum diam augue, ut maximus justo cursus sit amet. Fusce nibh mauris, aliquet et sapien sed, finibus hendrerit libero. Phasellus quis varius risus. Vivamus a aliquet purus, eget lobortis metus. In hac habitasse platea dictumst. Fusce vitae rutrum leo." },
                new Message { UserName = "Temple Cape", Email = "fbii.r2l7.6v-@b7cmkh2wi1.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-35), Text = "Curabitur faucibus ac arcu non commodo. Donec eros est, condimentum non tortor non, accumsan imperdiet ex. Sed nec dapibus metus. Aliquam scelerisque sed neque eget dapibus. Suspendisse potenti. Fusce fermentum massa nibh, sed posuere tortor tincidunt quis. Quisque gravida, est quis molestie rutrum, mauris enim ornare tellus, id ultrices orci nunc ac neque. Integer at dolor accumsan, rutrum ante sit amet, ullamcorper ligula. Integer in arcu dapibus, vulputate velit non, varius enim. Sed nec convallis nisi. Cras ut arcu a libero viverra vulputate non at augue." },
                new Message { UserName = "Clarissa Teets", Email = "ey5zqp5sy@aqcz29yurwvn.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-36), Text = "Pellentesque scelerisque leo quis velit fringilla vestibulum. Etiam id libero ullamcorper, condimentum ipsum quis, faucibus augue. Sed eget diam id quam bibendum aliquet. Mauris venenatis iaculis urna quis porta. Pellentesque purus massa, semper at metus id, convallis tristique ex. Sed quis augue tristique, vestibulum orci sed, interdum nisi. Aenean a fermentum nulla. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent dictum ante dapibus mi fringilla, vel fermentum orci condimentum. Vivamus id vulputate ligula. In feugiat ante sed erat sollicitudin, ut suscipit turpis tristique. Suspendisse porta libero quam, ut posuere nulla dictum eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Suspendisse volutpat blandit sem, at dictum lorem suscipit non." },
                new Message { UserName = "Gema Brumm", Email = "y91jeq4euo9@f4k9j891-wr8.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-37), Text = "Nam in libero a augue cursus tristique. Nunc quis enim imperdiet, posuere ligula eget, congue ex. Sed tincidunt odio tincidunt leo faucibus convallis. Donec bibendum metus nec nisl consequat, in tincidunt dui faucibus. Etiam non mi nibh. Vivamus varius metus eget sodales faucibus. Quisque volutpat ligula ut diam placerat, ac aliquet nisi accumsan. Integer arcu diam, aliquam ut tempor non, hendrerit at dui. Nullam pretium urna libero, quis faucibus enim venenatis vel. Cras in congue quam. Sed vehicula tincidunt varius. Donec tempus pulvinar urna et porta. Maecenas vitae lectus cursus, viverra dolor vitae, faucibus ante. Mauris convallis elementum neque, vel consectetur sapien dictum fermentum." },
                new Message { UserName = "Juliann Diggins", Email = "o0y3wv@mrjvwy.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-38), Text = "Duis pharetra tempor cursus. Donec mattis dolor nunc, suscipit malesuada velit lacinia at. Duis quis eros malesuada, luctus ante sed, fringilla ipsum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Sed in nunc augue. Sed tempor ante erat, sed porta eros scelerisque sed. Nunc efficitur non elit ac mattis. Morbi congue augue et magna dictum, non fermentum nisl bibendum. Nunc posuere venenatis eros, a vulputate mi blandit quis." },
                new Message { UserName = "Temika Ruoff", Email = "g3wnu8k@43ht25-xeb.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-39), Text = "Vivamus ac sapien vel sapien ornare viverra. Aliquam ac sapien lacinia, convallis eros et, rhoncus mi. Nulla ut sapien quam. Nulla maximus tincidunt varius. Donec mattis non lacus condimentum fermentum. Maecenas laoreet gravida leo, hendrerit semper velit finibus nec. Proin arcu leo, ultricies eu porta ac, bibendum a nulla. Sed varius maximus nunc lobortis auctor. Fusce ut gravida orci. Fusce tincidunt orci magna, ac sagittis turpis varius eu. Fusce tincidunt velit in arcu iaculis rhoncus. In non mi at augue hendrerit lacinia eget sit amet sapien. Proin ut diam sollicitudin, pellentesque magna in, porta est. Phasellus eu lectus quis metus rutrum luctus. Nulla et facilisis turpis, non egestas velit." },
                new Message { UserName = "Taneka Wellborn", Email = "z3x@icdryz.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-40), Text = "Sed pharetra commodo leo vitae efficitur. Suspendisse convallis ornare tortor in sollicitudin. Cras dictum est at tempus fringilla. Sed ultrices volutpat lorem id eleifend. Etiam erat turpis, egestas cursus nisi et, imperdiet tempor lorem. Nulla facilisi. Aliquam finibus diam quis suscipit ultrices." },
                new Message { UserName = "Lorita Ooten", Email = "pm3_@yj58cv.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-41), Text = "Vivamus eu finibus erat. Vestibulum in magna placerat, viverra orci eu, accumsan sapien. Suspendisse fermentum arcu tortor, rhoncus pharetra leo accumsan eget. Ut in varius libero. Phasellus fringilla egestas elit in tempor. Fusce convallis, enim vel finibus euismod, tellus elit tempor sapien, nec bibendum justo mauris a nisi. Vestibulum sed faucibus diam. Proin euismod, lorem ullamcorper rhoncus varius, lorem quam eleifend risus, blandit consequat lacus ante sed lacus. Quisque sapien ligula, lobortis condimentum rhoncus nec, tincidunt in quam. Nulla egestas urna non auctor elementum. Nullam sit amet malesuada libero. Mauris tincidunt, ex vel lacinia ullamcorper, urna neque fermentum neque, sit amet congue mi justo sit amet est." },
                new Message { UserName = "Lamonica Wedeking", Email = "m-w_@bw0ckzys32.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-42), Text = "Morbi sapien urna, convallis id viverra eget, aliquet id mauris. Mauris molestie porta semper. Nulla volutpat dapibus velit, et maximus nibh fermentum ac. Proin sed urna orci. Nulla condimentum id ex sed pretium. Duis eu vehicula ipsum. Aenean sit amet imperdiet urna." },
                new Message { UserName = "Wonda Mcdade", Email = "rdq7qg5cqy.sidc@taxsbjret.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-43), Text = "Morbi ut purus vitae dui dapibus venenatis nec non dui. Quisque at vulputate est, sit amet varius magna. Praesent eros velit, laoreet ut hendrerit at, scelerisque id sapien. Duis sed augue et ante iaculis molestie. Vestibulum vitae lacinia augue, sit amet rhoncus lacus. Etiam quis tortor ultrices, dictum ante molestie, imperdiet neque. Cras rhoncus facilisis urna. Fusce egestas velit nec felis fringilla ornare. Maecenas aliquam sed quam vitae pharetra. Maecenas sit amet mauris turpis. Quisque lacinia ante risus, nec congue felis facilisis et. Suspendisse suscipit tristique lorem ut pharetra. Curabitur vel fringilla risus, in blandit ante. Ut rhoncus lorem eu neque faucibus, non mattis diam dignissim. Nullam cursus est eget vulputate porta. Suspendisse potenti." },
                new Message { UserName = "Lizabeth Brabant", Email = "a-u.o@0d54s-vuohu.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-44), Text = "Mauris vulputate ut augue eget mollis. Nulla nec massa quis enim finibus bibendum eget in neque. Donec in dolor velit. Fusce posuere, neque vel egestas interdum, diam velit hendrerit nulla, eget viverra nisi dolor eu justo. Suspendisse placerat diam eu mollis sollicitudin. Nam tortor tortor, imperdiet imperdiet neque vitae, aliquam tristique orci. Mauris eget dolor mollis, facilisis elit sit amet, iaculis libero. Mauris molestie blandit auctor. Vivamus eu laoreet neque. Suspendisse rhoncus lectus nec commodo iaculis. Aliquam pulvinar sodales maximus." },
                new Message { UserName = "Sherill Doutt", Email = "y0-zvr2606mdxn@bempdpi7.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-45), Text = "Cras cursus eu ipsum quis condimentum. Duis nec nisl vitae elit blandit posuere. Suspendisse potenti. Ut sit amet mauris nisi. Curabitur congue fermentum nunc sollicitudin blandit. Donec consectetur posuere lacus euismod molestie. Vivamus sit amet libero quis tellus gravida porta vel vitae neque. Nulla metus metus, iaculis a euismod a, efficitur ac erat. Ut eu odio lacus. Praesent interdum dignissim imperdiet." },
                new Message { UserName = "Kurt Faw", Email = "stw1brd1obm0tb2@o6bsqot.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-46), Text = "Cras mollis commodo dignissim. Sed auctor a nisi non suscipit. Duis sollicitudin lacinia nisl, ut condimentum enim pretium vel. Etiam ullamcorper neque eget odio dignissim consectetur. Suspendisse leo sem, sagittis non ultrices sed, faucibus sit amet dui. Sed nec neque mattis, viverra turpis vitae, commodo leo. Integer ut purus tempor, rutrum urna at, ultricies ante." },
                new Message { UserName = "Flo Barrow", Email = "-zfgvcnbw-@1wo5k27wynx.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-47), Text = "Fusce eu urna sed sapien suscipit convallis nec eu elit. Aliquam erat volutpat. Pellentesque rhoncus lorem sit amet velit placerat, feugiat varius risus tincidunt. Vestibulum ultricies metus eget dolor maximus, et auctor orci varius. Vestibulum finibus felis sit amet ullamcorper ornare. In neque risus, tempus sed ligula ac, finibus bibendum augue. Vestibulum et imperdiet ligula, rutrum commodo diam. Nullam nec arcu sed nunc fermentum sodales. Aliquam in mauris risus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nam est ante, auctor porttitor condimentum eget, sodales ac diam. Integer magna massa, sagittis eget mattis non, commodo vel orci. Curabitur volutpat porta tincidunt. Suspendisse suscipit velit in facilisis malesuada. Nunc molestie egestas justo eget lobortis. Vivamus turpis magna, maximus quis velit vel, hendrerit auctor tellus." },
                new Message { UserName = "Luanne Tuller", Email = "tqj-64t@tzgz613h3mf.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-48), Text = "Nulla facilisi. Donec vitae leo mauris. In nisl nunc, finibus non tellus id, molestie vestibulum nibh. Donec nec dui pharetra, congue neque quis, egestas neque. Praesent malesuada nisi eget lectus gravida, faucibus rhoncus risus tempus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Duis volutpat, lorem eu blandit bibendum, sapien sapien scelerisque magna, in sollicitudin neque enim non dolor." },
                new Message { UserName = "Shaneka Lamb", Email = "vlhlg6_tr@lk92t7ukod-u.com", Homepage = @"https://www.google.com.ua/", CreatedAt = DateTime.Now.AddHours(-49), Text = "Pellentesque tristique quam vel mi suscipit pharetra. Phasellus at maximus sem, a elementum turpis. Nunc dapibus mi justo, et mollis ipsum placerat at. Nullam non elit id diam lacinia faucibus eu vel nulla. Fusce bibendum, leo at dapibus faucibus, turpis leo facilisis mi, eget pulvinar lacus felis non lorem. In hac habitasse platea dictumst. Proin lorem tortor, consequat eget malesuada sed, dignissim non nibh. Etiam pharetra tristique arcu, ac laoreet justo suscipit eget. Cras ut efficitur neque. Suspendisse potenti. Phasellus id ligula ac velit vehicula vestibulum. Fusce vitae pulvinar tortor, eget finibus urna. Sed in vehicula lorem, convallis commodo est. Proin vel faucibus lacus, ac euismod lectus. Nunc justo lorem, commodo in fringilla vel, finibus ut diam." }
            );
        }
    }
}
