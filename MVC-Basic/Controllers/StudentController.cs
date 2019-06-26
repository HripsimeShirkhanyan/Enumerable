using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using MVC_Basic.Models;

namespace MVC_Basic.Controllers
{
    public class StudentController : Controller
    {

        static IList<Student> studentList = new List<Student>() { 
                    new Student(){ Id=1, Name="Ani", Department="HR", Age = 18 },
                    new Student(){ Id=2, Name="Anna", Department="PR", Age = 21 },
                    new Student(){ Id=3, Name="Karen", Department="IT", Age = 25 },
                    new Student(){ Id=4, Name="Narek", Department="IT", Age = 20 },
                    new Student(){ Id=5, Name="Anahit", Department="Marketing", Age = 31 },
                    new Student(){ Id=6, Name="Liana", Department="HR", Age = 17 },
                    new Student(){ Id=7, Name="Rob", Department="Management", Age = 19 }
                };
        public IActionResult Index()//sargi vor es actione _index view-i mej studen list veradardzni, default edtex chi avelacnelu? 
            //oy,apres, de et view-n sargi
        {
            return View("_index", studentList);
        }

        public IActionResult Edit(int Id)
        {
            Student std = null;
            //nayi
            //es erku gracnel nuyn bann en anum, erb du linq es grum , inqe takic anuma en inch yes greci
            //ba inchi es dem linqin, Artyomn el er vogevorvac xosum :D
            //hetaga developmenti hamar djvara, du ches karoxanum kardas incha grac, kardum es bayc dandax, heto meje bana petq linum poxel djvara aveli
            // orinak ogtagordzes (where) te (find)? tex kara lini vor find ogtagordzes tans ex, giteir? hastat Artyomnel chgiter, yes el chgitey
            // minchev vor 1 or tanjveci 
            // nayi senc te nenc ogtaogrdzelu es, bayc ashxati chogtagordzes!!! ete karas, piti contextic haskanas 
            // yes permissioneri mej shat texer linq em ogtaogrdzum, vorovhetev ettex imast chuni urish b an grel. linqe shat karja stacvum, b
            //bayc takic anuma im grace, nenc chi inqe aveli araga
            //Ok? exav sensei :D de hima senc orinak qez asem
            // Dzer microsofti govac linqov, vor ov galisa ettexic linqa sirum, mekel entity framework,
            //gti et id-ov studente u ira tariqe poxi u iran veragri mer popoxakanin
            // zzvelia che lineleu vor mi 2 arjeq el petq lini poxel,
            //isk im gracov du parz haskanum es inch es anum vortex es anum, u ete hetagayum mijamtelu xndir el lini shat hesht kardalu es gract u poxes,
            // meje nor logia aavelacnes
            //ok? haskacar? haskaca, es commentner@ chjnjes eli, heto aveli haskanali a linum inch enq arel :D


            //std = studentList.Where(s => s.Id == Id).FirstOrDefault();// qo grac paymani hamapatasxanox kaam arajine kverdzni kam ete dranc mej ka default :D eshutyun eli
            //:D bayc ete qo poxc texum uzum em entadrenq grem da, vortex piti grem// aysinqn? default arjeq unena? che, spasi asem 
            //inch em uzum :D hima es verevi linqov code-um ed mas@ inch piti aner? nayer id==Id, u verdzner arajine kam defaulte, ete chhamapatasxani null
            //hima asa, isk mer poxac tarberakum ete uzum em ed nuyn dzev vercni? vortex piti grem firstordefault, petq chi :D 
            // mer std arden ira et default nullna. ete khamapatasxani kveragrvi. verj, @nkav tex@ :D vor vopshe sirtd texe ynkni, 
            //nenc chlini 2 id nuyne unena u 2rde veragrvi))) :D bayc meka eshutyuna! ay hima es el @nduneci :D
            //che tenc mi mtaci, et yes tenc em mtacum, et past chi yes jisht em, prosot indz pordze cuyca tvel vor qich ogtagordzem
            //de es pahin inch ases @ndunelu em, pordz dzerq berem khakacharem :D,cec kutes :d AROXJ MRcakcutyun kapahovem,cec kutes
            // capslk du es an@ndhat miacnum?:d che, hastat che, chem havatum, ham el ba qo dzerq@ kgna, vor asum es cec kutes:D
            //mtacum em
            // ba es edite inchi ches grel? to es shat imanam, piti karanam vor grem ;d
            for (int i = 0;i<studentList.Count;i++)
            {
                if(studentList[i].Id == Id)
                {
                    std = studentList[i];
                    break;
                }
            }
            //es en tesqi mej inchn a apahovum// nayi senc gtnum enq en studente vorin uzum enq xmbagrenq, xbagreluc ches bacum nor ejic grum che?
            // ayl yndamene et exac tvyalneri vraic qo popoxutyunern es anuum, senc gtnum enq u texadrum enq mer sargac inputneri mej vor ettexic xmbagrenq,
            //vor es chanenq chenq tesni orinak qani tarekana vor mi hat el sxala grac ok? mi rope, laaav lav, im xndir@ gites vorn a,
            //chem patkeracnum vor es inqnuruyn faymem grem :D che dy anfaym ches elmi :D 
            //qde ha , mardkanc het shpman jamanak shaaat faymov em, qo sxale vor du qez teragnahatum es!!!!!!!!!!!!
            //khaxtaharem mi or, erevi.!!!heto? spasi sharunakutyun@ nayem
            //es gites incha? linq query, queryn gites incha? che dra hamar el asum em piti db sovores)
            // nayi senc haskaci, mi toxi vra paymannert grelov stanum es inchvor arjeq, kam gtnum es, linqe ira mej shaaaaaat baner uni
            ///bayc yes zzvum em linqic :D 
            /// u qez el chem toxelu ogtagordzes, ete iharke ettex et miak jisht lucume chi
            //che, gites inchi asecir 0? uxxaki :D,che!! vor var eir grel dra hamar, ay vor skzbice el Student greir khaskanair vor 0 chi lini, mtqovs cher ancel
            //vor karar tenc tpavorver :) pastoren iroq vat ban a var@// kardale djvaracnuma, heto bacelu es sax var lini u chhaskanas vore incha
            //plus erb du grum es var ruun aneluc inqe meka Studenta darnum, el imaste vorna var grelu? isk ed dandaxacnum a?che,
            //erb run exav, inqe et jamanak arden poxuma var-ere dardznum hamapatasxan ,ok? ok
            //tesar? haa, bayc mi ban el harcnem, is ay es mas@
            return View(std);//inchi hamara error? vorovhetev for-ic durs enq, chi hasknum vor arjeq enq verangrel,ba inch anenq? verevum 0 veragrenq? 0?
        }

        [HttpPost]
        public IActionResult Edit(Student std)
        {
            // edite nenc gri vor tariq dep,mek el anune edit anes
            //tenam vonc es grelu
            //ches tena, vorovhetev chem kara grem :D hastat? piti vor
            //esqan baner ka :D
            if (ModelState.IsValid)// senc menq stugum enq mer modele hamapatasxanuma mer uzac validationin te che, ete hamapatasxani mer gorcoxutyune kanneq
                // ete che het enq uxarkum view u cuyc enq talis userin te inche chi hamapatasxanum, ay et cuyctelu mase menq enq voroshum vonc cuyc tanq,
                //hazar dzev kara lini, en htmli mej grace et razori default dzevna ok? ha, ok, bayc es depqum ete qo grac@ chgrenq ed razori default-@ nenc chi vor eakan 
                //der a xaxum, che? vor chgrenq chenq imana incha exel vor validatione chi ancel, ok ok spasi
            {
                for (int i = 0; i < studentList.Count; i++)
                {
                    if (studentList[i].Id == std.Id)
                    {
                        studentList[i].Name = std.Name;
                        studentList[i].Department = std.Department;
                        studentList[i].Age = std.Age;
                        //senc inch klini?
                        //en inch uzum eir, indz mi hardzra asa vor ashxatacnenq, edit anenq, erevi klini
                        //de pordzi
                        //petq er tenc anel? :D spaspum ei vor chanes,xosam vret :D inch dajan mard es bayc
                    }
                }
                return RedirectToAction("Index");
            }
            if(std.ErrMsgs == null)
            {
                std.ErrMsgs = new List<string>();
            }
            std.ErrMsgs.AddRange(ValidationResponse(ViewData));
            return View(std);
        }
        private List<string> ValidationResponse(ViewDataDictionary viewData)
        {
            int count = viewData.ModelState.Keys.Count();

            List<string> errorMsgList = new List<string>(count);

            foreach (string keyProp in viewData.ModelState.Keys)
            {
                ModelErrorCollection collection = ViewData.ModelState[keyProp].Errors;

                errorMsgList.AddRange(collection.Select(m => m.ErrorMessage));//tesar stex linq em ogtagordzel? :D haa tesa, charji miha gtnel es message meka senc el chenq talis :D sovorelu hamara)))du harc tur
                //uxexs kaxel a arden :D
            }
            return errorMsgList;
        } //ay es gracs mi nayi, et hastat petq chi qez,, ok? lav :) de lav miqich el du qez u qez sovori vor harcer lini asa
        //exav, merci shaaat, bayc nenc chlini indzanic heto pakes gnas parkes :D chee, es jamerin chem parkum :D,tekuz tv nayex :D ay mard che, vay, es ho im tshnamin chem
        //ba inch es,,, de ha, irakanum tshnamis indznic lav a verabervum indz :D sksssssseeeeeeeeeeeeeeeeeeeeeeeec!!!!!!!!!!!!!!!!!!!
        //qez qani angam asem du qo masin tenc vat mi mtaci!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //kashxatem, der chi stacvum ,, eee tenc chi lini. el chanes tenc! lav de yes gnaci, poka :D
    }
}