//--- Aura Script -----------------------------------------------------------
// Physis
//--- Description -----------------------------------------------------------
// Warp, prop, and spawn definitions for Physis.
//---------------------------------------------------------------------------

using Aura.Channel.Scripting.Scripts;
using Aura.Channel.Network.Sending;

public class PhysisRegionScript : BaseScript
{
	public override void Load()
	{
		LoadWarps();
		LoadPropDrops();
	}
	
	public void LoadWarps()
	{
		SetPropBehavior(45074655274401794, PropWarp(3200, 338404, 252538));
		SetPropBehavior(45050599166771232, PropWarp(3200, 405020, 276371));
		SetPropBehavior(45049748759118190, PropWarp(3200, 196431, 161470));
		SetPropBehavior(45036902511869959, PropWarp(3200, 290325, 212149));
		SetPropBehavior(45049740170559492, PropWarp(3202, 54993, 123796));
		SetPropBehavior(45049740173508730, PropWarp(9001, 8001, 5735));
	}
	
	public void LoadPropDrops()
	{
		SetPropBehavior(45049740169641997, PropDrop(2));
		SetPropBehavior(45049740169641998, PropDrop(2));
		SetPropBehavior(45049740169642000, PropDrop(2));
		SetPropBehavior(45049740169642001, PropDrop(2));
		SetPropBehavior(45049740170100739, PropDrop(2));
		SetPropBehavior(45049740170100740, PropDrop(2));
		SetPropBehavior(45049740170100741, PropDrop(2));
		SetPropBehavior(45049740170100742, PropDrop(2));
		SetPropBehavior(45049740170100743, PropDrop(2));
		SetPropBehavior(45049740170100745, PropDrop(2));
		SetPropBehavior(45049740170559531, PropDrop(2));
		SetPropBehavior(45049740170559535, PropDrop(2));
		SetPropBehavior(45049740170559536, PropDrop(2));
		SetPropBehavior(45049740170559537, PropDrop(2));
		SetPropBehavior(45049740170559538, PropDrop(2));
		SetPropBehavior(45049740170625041, PropDrop(2));
		SetPropBehavior(45049740170625042, PropDrop(2));
		SetPropBehavior(45049740170625043, PropDrop(2));
		SetPropBehavior(45049740170625044, PropDrop(2));
		SetPropBehavior(45049740170625045, PropDrop(2));
		SetPropBehavior(45049740170690591, PropDrop(2));
		SetPropBehavior(45049740170690596, PropDrop(2));
		SetPropBehavior(45049740170690624, PropDrop(2));
		SetPropBehavior(45049740170756098, PropDrop(2));
		SetPropBehavior(45049740171018242, PropDrop(2));
		SetPropBehavior(45049740171018243, PropDrop(2));
		SetPropBehavior(45049740171083794, PropDrop(2));
		SetPropBehavior(45049740171083795, PropDrop(2));
		SetPropBehavior(45049740171083796, PropDrop(2));
		SetPropBehavior(45049740171083797, PropDrop(2));
		SetPropBehavior(45049740171083798, PropDrop(2));
		SetPropBehavior(45049740171083799, PropDrop(2));
		SetPropBehavior(45049740171083800, PropDrop(2));
		SetPropBehavior(45049740171083801, PropDrop(2));
		SetPropBehavior(45049740171083802, PropDrop(2));
		SetPropBehavior(45049740171149341, PropDrop(2));
		SetPropBehavior(45049740171149342, PropDrop(2));
		SetPropBehavior(45049740171149343, PropDrop(2));
		SetPropBehavior(45049740171149345, PropDrop(2));
		SetPropBehavior(45049740171149347, PropDrop(2));
		SetPropBehavior(45049740171149349, PropDrop(2));
		SetPropBehavior(45049740171149356, PropDrop(2));
		SetPropBehavior(45049740171149364, PropDrop(2));
		SetPropBehavior(45049740171149365, PropDrop(2));
		SetPropBehavior(45049740171149366, PropDrop(2));
		SetPropBehavior(45049740171149367, PropDrop(2));
		SetPropBehavior(45049740171149368, PropDrop(2));
		SetPropBehavior(45049740171149382, PropDrop(2));
		SetPropBehavior(45049740171149455, PropDrop(2));
		SetPropBehavior(45049740171149463, PropDrop(2));
		SetPropBehavior(45049740171214857, PropDrop(2));
		SetPropBehavior(45049740171214860, PropDrop(2));
		SetPropBehavior(45049740171214861, PropDrop(2));
		SetPropBehavior(45049740171214862, PropDrop(2));
		SetPropBehavior(45049740171214881, PropDrop(2));
		SetPropBehavior(45049740171214890, PropDrop(2));
		SetPropBehavior(45049740171214891, PropDrop(2));
		SetPropBehavior(45049740171214941, PropDrop(2));
		SetPropBehavior(45049740171411466, PropDrop(2));
		SetPropBehavior(45049740171804686, PropDrop(2));
		SetPropBehavior(45049740171870249, PropDrop(2));
		SetPropBehavior(45049740171870250, PropDrop(2));
		SetPropBehavior(45049740171870251, PropDrop(2));
		SetPropBehavior(45049740171870252, PropDrop(2));
		SetPropBehavior(45049740172001281, PropDrop(2));
		SetPropBehavior(45049740172001282, PropDrop(2));
		SetPropBehavior(45049740172001283, PropDrop(2));
		SetPropBehavior(45049740172001284, PropDrop(2));
		SetPropBehavior(45049740172001285, PropDrop(2));
		SetPropBehavior(45049740172001286, PropDrop(2));
		SetPropBehavior(45049740172001287, PropDrop(2));
		SetPropBehavior(45049740172001288, PropDrop(2));
		SetPropBehavior(45049740172001289, PropDrop(2));
		SetPropBehavior(45049740172001290, PropDrop(2));
		SetPropBehavior(45049740172001291, PropDrop(2));
		SetPropBehavior(45049740172001292, PropDrop(2));
		SetPropBehavior(45049740172001293, PropDrop(2));
		SetPropBehavior(45049740172001294, PropDrop(2));
		SetPropBehavior(45049740172066820, PropDrop(2));
		SetPropBehavior(45049740172066826, PropDrop(2));
		SetPropBehavior(45049740172066827, PropDrop(2));
		SetPropBehavior(45049740172066828, PropDrop(2));
		SetPropBehavior(45049740172066829, PropDrop(2));
		SetPropBehavior(45049740172066830, PropDrop(2));
		SetPropBehavior(45049740172066831, PropDrop(2));
		SetPropBehavior(45049740172066846, PropDrop(2));
		SetPropBehavior(45049740172066847, PropDrop(2));
		SetPropBehavior(45049740172066849, PropDrop(2));
		SetPropBehavior(45049740172066854, PropDrop(2));
		SetPropBehavior(45049740172066861, PropDrop(2));
		SetPropBehavior(45049740172066862, PropDrop(2));
		SetPropBehavior(45049740172066865, PropDrop(2));
		SetPropBehavior(45049740172066866, PropDrop(2));
		SetPropBehavior(45049740172066867, PropDrop(2));
		SetPropBehavior(45049740172066871, PropDrop(2));
		SetPropBehavior(45049740172066887, PropDrop(2));
		SetPropBehavior(45049740172132356, PropDrop(2));
		SetPropBehavior(45049740172132384, PropDrop(2));
		SetPropBehavior(45049740172132386, PropDrop(2));
		SetPropBehavior(45049740172132387, PropDrop(2));
		SetPropBehavior(45049740172132389, PropDrop(2));
		SetPropBehavior(45049740172132390, PropDrop(2));
		SetPropBehavior(45049740172132391, PropDrop(2));
		SetPropBehavior(45049740172132392, PropDrop(2));
		SetPropBehavior(45049740172132395, PropDrop(2));
		SetPropBehavior(45049740172132397, PropDrop(2));
		SetPropBehavior(45049740172132399, PropDrop(2));
		SetPropBehavior(45049740172197889, PropDrop(2));
		SetPropBehavior(45049740172197890, PropDrop(2));
		SetPropBehavior(45049740172197891, PropDrop(2));
		SetPropBehavior(45049740172328998, PropDrop(2));
		SetPropBehavior(45049740172394509, PropDrop(2));
		SetPropBehavior(45049740172394511, PropDrop(2));
		SetPropBehavior(45049740172394512, PropDrop(2));
		SetPropBehavior(45049740172394513, PropDrop(2));
		SetPropBehavior(45049740172394514, PropDrop(2));
		SetPropBehavior(45049740172394515, PropDrop(2));
		SetPropBehavior(45049740172460034, PropDrop(2));
		SetPropBehavior(45049740172460035, PropDrop(2));
		SetPropBehavior(45049740172460036, PropDrop(2));
		SetPropBehavior(45049740172460037, PropDrop(2));
		SetPropBehavior(45049740172460038, PropDrop(2));
		SetPropBehavior(45049740172460039, PropDrop(2));
		SetPropBehavior(45049740172460040, PropDrop(2));
		SetPropBehavior(45049740172460041, PropDrop(2));
		SetPropBehavior(45049740172460042, PropDrop(2));
		SetPropBehavior(45049740172460043, PropDrop(2));
		SetPropBehavior(45049740172460044, PropDrop(2));
		SetPropBehavior(45049740172460045, PropDrop(2));
		SetPropBehavior(45049740172460046, PropDrop(2));
		SetPropBehavior(45049740172460052, PropDrop(2));
		SetPropBehavior(45049740172525569, PropDrop(1));
		SetPropBehavior(45049740172525592, PropDrop(2));
		SetPropBehavior(45049740172525596, PropDrop(2));
		SetPropBehavior(45049740172525597, PropDrop(2));
		SetPropBehavior(45049740172525598, PropDrop(2));
		SetPropBehavior(45049740172525601, PropDrop(2));
		SetPropBehavior(45049740172525621, PropDrop(2));
		SetPropBehavior(45049740172525622, PropDrop(2));
		SetPropBehavior(45049740172525626, PropDrop(2));
		SetPropBehavior(45049740172525642, PropDrop(2));
		SetPropBehavior(45049740172525647, PropDrop(2));
		SetPropBehavior(45049740172525649, PropDrop(2));
		SetPropBehavior(45049740172525650, PropDrop(2));
		SetPropBehavior(45049740172525651, PropDrop(2));
		SetPropBehavior(45049740172525652, PropDrop(2));
		SetPropBehavior(45049740172525654, PropDrop(2));
		SetPropBehavior(45049740172525655, PropDrop(2));
		SetPropBehavior(45049740172525656, PropDrop(2));
		SetPropBehavior(45049740172525691, PropDrop(2));
		SetPropBehavior(45049740172525692, PropDrop(2));
		SetPropBehavior(45049740172525720, PropDrop(2));
		SetPropBehavior(45049740172525721, PropDrop(2));
		SetPropBehavior(45049740172525728, PropDrop(2));
		SetPropBehavior(45049740172525729, PropDrop(2));
		SetPropBehavior(45049740172525733, PropDrop(2));
		SetPropBehavior(45049740172525734, PropDrop(2));
		SetPropBehavior(45049740172525735, PropDrop(2));
		SetPropBehavior(45049740172525737, PropDrop(2));
		SetPropBehavior(45049740172525823, PropDrop(2));
		SetPropBehavior(45049740172525824, PropDrop(2));
		SetPropBehavior(45049740172525828, PropDrop(2));
		SetPropBehavior(45049740172525834, PropDrop(2));
		SetPropBehavior(45049740172525865, PropDrop(2));
		SetPropBehavior(45049740172525866, PropDrop(2));
		SetPropBehavior(45049740172525889, PropDrop(2));
		SetPropBehavior(45049740172525890, PropDrop(2));
		SetPropBehavior(45049740172591110, PropDrop(2));
		SetPropBehavior(45049740172591112, PropDrop(2));
		SetPropBehavior(45049740172591115, PropDrop(2));
		SetPropBehavior(45049740172591116, PropDrop(2));
		SetPropBehavior(45049740172591118, PropDrop(2));
		SetPropBehavior(45049740172591119, PropDrop(2));
		SetPropBehavior(45049740172591126, PropDrop(2));
		SetPropBehavior(45049740172591136, PropDrop(2));
		SetPropBehavior(45049740172591137, PropDrop(2));
		SetPropBehavior(45049740172591148, PropDrop(2));
		SetPropBehavior(45049740172591150, PropDrop(2));
		SetPropBehavior(45049740172591151, PropDrop(2));
		SetPropBehavior(45049740172591152, PropDrop(2));
		SetPropBehavior(45049740172591153, PropDrop(2));
		SetPropBehavior(45049740172591159, PropDrop(2));
		SetPropBehavior(45049740172591160, PropDrop(2));
		SetPropBehavior(45049740172591161, PropDrop(2));
		SetPropBehavior(45049740172591162, PropDrop(2));
		SetPropBehavior(45049740172591163, PropDrop(2));
		SetPropBehavior(45049740172591164, PropDrop(2));
		SetPropBehavior(45049740172591165, PropDrop(2));
		SetPropBehavior(45049740172591166, PropDrop(2));
		SetPropBehavior(45049740172591168, PropDrop(2));
		SetPropBehavior(45049740172591170, PropDrop(2));
		SetPropBehavior(45049740172591176, PropDrop(2));
		SetPropBehavior(45049740172591177, PropDrop(2));
		SetPropBehavior(45049740172591184, PropDrop(2));
		SetPropBehavior(45049740172591192, PropDrop(2));
		SetPropBehavior(45049740172591193, PropDrop(2));
		SetPropBehavior(45049740172591194, PropDrop(2));
		SetPropBehavior(45049740172591223, PropDrop(2));
		SetPropBehavior(45049740172591238, PropDrop(2));
		SetPropBehavior(45049740172591239, PropDrop(2));
		SetPropBehavior(45049740172591249, PropDrop(2));
		SetPropBehavior(45049740172591278, PropDrop(2));
		SetPropBehavior(45049740172591298, PropDrop(2));
		SetPropBehavior(45049740172591303, PropDrop(2));
		SetPropBehavior(45049740172591314, PropDrop(2));
		SetPropBehavior(45049740172656648, PropDrop(2));
		SetPropBehavior(45049740172656649, PropDrop(2));
		SetPropBehavior(45049740172656650, PropDrop(2));
		SetPropBehavior(45049740172656651, PropDrop(2));
		SetPropBehavior(45049740172656652, PropDrop(2));
		SetPropBehavior(45049740172656653, PropDrop(2));
		SetPropBehavior(45049740172656654, PropDrop(2));
		SetPropBehavior(45049740172656656, PropDrop(2));
		SetPropBehavior(45049740172656657, PropDrop(2));
		SetPropBehavior(45049740172656658, PropDrop(2));
		SetPropBehavior(45049740172656659, PropDrop(2));
		SetPropBehavior(45049740172656660, PropDrop(2));
		SetPropBehavior(45049740172656662, PropDrop(2));
		SetPropBehavior(45049740172656663, PropDrop(2));
		SetPropBehavior(45049740172656664, PropDrop(2));
		SetPropBehavior(45049740172656665, PropDrop(2));
		SetPropBehavior(45049740172656666, PropDrop(2));
		SetPropBehavior(45049740172656667, PropDrop(2));
		SetPropBehavior(45049740172656668, PropDrop(2));
		SetPropBehavior(45049740172656669, PropDrop(2));
		SetPropBehavior(45049740172656671, PropDrop(2));
		SetPropBehavior(45049740172656672, PropDrop(2));
		SetPropBehavior(45049740172656673, PropDrop(2));
		SetPropBehavior(45049740172656674, PropDrop(2));
		SetPropBehavior(45049740172656675, PropDrop(2));
		SetPropBehavior(45049740172656683, PropDrop(2));
		SetPropBehavior(45049740172722179, PropDrop(2));
		SetPropBehavior(45049740172722183, PropDrop(2));
		SetPropBehavior(45049740172722184, PropDrop(2));
		SetPropBehavior(45049740172722185, PropDrop(2));
		SetPropBehavior(45049740172722186, PropDrop(2));
		SetPropBehavior(45049740172722187, PropDrop(2));
		SetPropBehavior(45049740172722188, PropDrop(2));
		SetPropBehavior(45049740172722189, PropDrop(2));
		SetPropBehavior(45049740172722190, PropDrop(2));
		SetPropBehavior(45049740172787729, PropDrop(2));
		SetPropBehavior(45049740172787730, PropDrop(2));
		SetPropBehavior(45049740172787733, PropDrop(2));
		SetPropBehavior(45049740172787738, PropDrop(2));
		SetPropBehavior(45049740172787739, PropDrop(2));
		SetPropBehavior(45049740172787743, PropDrop(2));
		SetPropBehavior(45049740172787746, PropDrop(2));
		SetPropBehavior(45049740172787747, PropDrop(2));
		SetPropBehavior(45049740172787748, PropDrop(2));
		SetPropBehavior(45049740172787749, PropDrop(2));
		SetPropBehavior(45049740172787750, PropDrop(2));
		SetPropBehavior(45049740172787751, PropDrop(2));
		SetPropBehavior(45049740172787752, PropDrop(2));
		SetPropBehavior(45049740172787753, PropDrop(2));
		SetPropBehavior(45049740172787754, PropDrop(2));
		SetPropBehavior(45049740172787755, PropDrop(2));
		SetPropBehavior(45049740172787756, PropDrop(2));
		SetPropBehavior(45049740172787757, PropDrop(2));
		SetPropBehavior(45049740172787758, PropDrop(2));
		SetPropBehavior(45049740172787759, PropDrop(2));
		SetPropBehavior(45049740172787760, PropDrop(2));
		SetPropBehavior(45049740172787761, PropDrop(2));
		SetPropBehavior(45049740172787762, PropDrop(2));
		SetPropBehavior(45049740172787763, PropDrop(2));
		SetPropBehavior(45049740172787764, PropDrop(2));
		SetPropBehavior(45049740172787765, PropDrop(2));
		SetPropBehavior(45049740172787766, PropDrop(2));
		SetPropBehavior(45049740172853249, PropDrop(2));
		SetPropBehavior(45049740172853250, PropDrop(2));
		SetPropBehavior(45049740172853251, PropDrop(2));
		SetPropBehavior(45049740172853252, PropDrop(2));
		SetPropBehavior(45049740172853253, PropDrop(2));
		SetPropBehavior(45049740172853254, PropDrop(2));
		SetPropBehavior(45049740172853255, PropDrop(2));
		SetPropBehavior(45049740172918786, PropDrop(2));
		SetPropBehavior(45049740172918787, PropDrop(2));
		SetPropBehavior(45049740172918788, PropDrop(2));
		SetPropBehavior(45049740172918789, PropDrop(2));
		SetPropBehavior(45049740172918790, PropDrop(2));
		SetPropBehavior(45049740172984322, PropDrop(2));
		SetPropBehavior(45049740172984323, PropDrop(2));
		SetPropBehavior(45049740172984328, PropDrop(2));
		SetPropBehavior(45049740172984330, PropDrop(2));
		SetPropBehavior(45049740172984334, PropDrop(2));
		SetPropBehavior(45049740172984336, PropDrop(2));
		SetPropBehavior(45049740172984337, PropDrop(2));
		SetPropBehavior(45049740172984338, PropDrop(2));
		SetPropBehavior(45049740172984339, PropDrop(2));
		SetPropBehavior(45049740172984359, PropDrop(2));
		SetPropBehavior(45049740172984371, PropDrop(2));
		SetPropBehavior(45049740172984372, PropDrop(2));
		SetPropBehavior(45049740173049860, PropDrop(2));
		SetPropBehavior(45049740173049862, PropDrop(2));
		SetPropBehavior(45049740173049863, PropDrop(2));
		SetPropBehavior(45049740173049864, PropDrop(2));
		SetPropBehavior(45049740173049865, PropDrop(2));
		SetPropBehavior(45049740173049866, PropDrop(2));
		SetPropBehavior(45049740173049868, PropDrop(2));
		SetPropBehavior(45049740173049869, PropDrop(2));
		SetPropBehavior(45049740173049870, PropDrop(2));
		SetPropBehavior(45049740173049871, PropDrop(2));
		SetPropBehavior(45049740173049872, PropDrop(2));
		SetPropBehavior(45049740173049882, PropDrop(2));
		SetPropBehavior(45049740173049900, PropDrop(2));
		SetPropBehavior(45049740173049901, PropDrop(2));
		SetPropBehavior(45049740173049902, PropDrop(2));
		SetPropBehavior(45049740173049913, PropDrop(2));
		SetPropBehavior(45049740173049931, PropDrop(2));
		SetPropBehavior(45049740173049933, PropDrop(2));
		SetPropBehavior(45049740173049935, PropDrop(2));
		SetPropBehavior(45049740173115393, PropDrop(2));
		SetPropBehavior(45049740173115394, PropDrop(2));
		SetPropBehavior(45049740173115395, PropDrop(2));
		SetPropBehavior(45049740173115401, PropDrop(2));
		SetPropBehavior(45049740173115402, PropDrop(2));
		SetPropBehavior(45049740173115404, PropDrop(2));
		SetPropBehavior(45049740173115405, PropDrop(2));
		SetPropBehavior(45049740173115406, PropDrop(2));
		SetPropBehavior(45049740173115407, PropDrop(2));
		SetPropBehavior(45049740173115408, PropDrop(2));
		SetPropBehavior(45049740173115409, PropDrop(2));
		SetPropBehavior(45049740173115424, PropDrop(2));
		SetPropBehavior(45049740173115425, PropDrop(2));
		SetPropBehavior(45049740173115432, PropDrop(2));
		SetPropBehavior(45049740173115434, PropDrop(2));
		SetPropBehavior(45049740173115439, PropDrop(2));
		SetPropBehavior(45049740173115440, PropDrop(2));
		SetPropBehavior(45049740173115443, PropDrop(2));
		SetPropBehavior(45049740173115446, PropDrop(2));
		SetPropBehavior(45049740173115451, PropDrop(2));
		SetPropBehavior(45049740173115452, PropDrop(2));
		SetPropBehavior(45049740173180929, PropDrop(2));
		SetPropBehavior(45049740173180938, PropDrop(2));
		SetPropBehavior(45049740173180939, PropDrop(2));
		SetPropBehavior(45049740173246465, PropDrop(2));
		SetPropBehavior(45049740173246466, PropDrop(2));
		SetPropBehavior(45049740173246467, PropDrop(2));
		SetPropBehavior(45049740173246468, PropDrop(2));
		SetPropBehavior(45049740173246469, PropDrop(2));
		SetPropBehavior(45049740173246470, PropDrop(2));
		SetPropBehavior(45049740173312001, PropDrop(2));
		SetPropBehavior(45049740173312002, PropDrop(2));
		SetPropBehavior(45049740173312003, PropDrop(2));
		SetPropBehavior(45049740173377538, PropDrop(2));
		SetPropBehavior(45049740173377539, PropDrop(2));
		SetPropBehavior(45049740173377540, PropDrop(2));
		SetPropBehavior(45049740173377541, PropDrop(2));
		SetPropBehavior(45049740173377542, PropDrop(2));
		SetPropBehavior(45049740173508617, PropDrop(2));
		SetPropBehavior(45049740173508618, PropDrop(2));
		SetPropBehavior(45049740173508619, PropDrop(2));
		SetPropBehavior(45049740173508621, PropDrop(2));
		SetPropBehavior(45049740173508628, PropDrop(2));
		SetPropBehavior(45049740173508629, PropDrop(2));
		SetPropBehavior(45049740173508630, PropDrop(2));
		SetPropBehavior(45049740173508633, PropDrop(2));
		SetPropBehavior(45049740173508634, PropDrop(2));
		SetPropBehavior(45049740173508635, PropDrop(2));
		SetPropBehavior(45049740173508705, PropDrop(2));
		SetPropBehavior(45049740173508715, PropDrop(2));
		SetPropBehavior(45049740173508726, PropDrop(2));
		SetPropBehavior(45049740173574146, PropDrop(2));
	}
}