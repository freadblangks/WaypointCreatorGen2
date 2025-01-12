using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaypointCreatorGen2.Enums
{
    [Flags]
    public enum MoveSplineFlag : uint
    {
        None                = 0x00000000,
        Unknown_0x1         = 0x00000001,           // NOT VERIFIED
        Unknown_0x2         = 0x00000002,           // NOT VERIFIED
        Unknown_0x4         = 0x00000004,           // NOT VERIFIED
        JumpOrientationFixed= 0x00000008,           // Model orientation fixed (jump animation)
        FallingSlow         = 0x00000010,
        Done                = 0x00000020,
        Falling             = 0x00000040,           // Affects elevation computation, can't be combined with Parabolic flag
        No_Spline           = 0x00000080,
        Unknown_0x100       = 0x00000100,           // NOT VERIFIED
        Flying              = 0x00000200,           // Smooth movement(Catmullrom interpolation mode), flying animation
        OrientationFixed    = 0x00000400,           // Model orientation fixed (knockback animation)
        Catmullrom          = 0x00000800,           // Used Catmullrom interpolation mode
        Cyclic              = 0x00001000,           // Movement by cycled spline
        Enter_Cycle         = 0x00002000,           // Everytimes appears with cyclic flag in monster move packet, erases first spline vertex after first cycle done
        Frozen              = 0x00004000,           // Will never arrive
        TransportEnter      = 0x00008000,
        TransportExit       = 0x00010000,
        Unknown_0x20000     = 0x00020000,           // NOT VERIFIED
        Unknown_0x40000     = 0x00040000,           // NOT VERIFIED
        Backward            = 0x00080000,
        SmoothGroundPath    = 0x00100000,
        CanSwim             = 0x00200000,
        UncompressedPath    = 0x00400000,
        Unknown_0x800000    = 0x00800000,           // NOT VERIFIED
        FastSteering        = 0x01000000,           // Predicts spline only 500ms into the future for smoothing instead of 1s (making turns sharper) and turns off clientside obstacle detection
        Animation           = 0x02000000,           // Plays animation after some time passed
        Parabolic           = 0x04000000,           // Affects elevation computation, can't be combined with Falling flag
        FadeObject          = 0x08000000,
        Steering            = 0x10000000,
        UnlimitedSpeed      = 0x20000000,
        Unknown_0x40000000  = 0x40000000,           // NOT VERIFIED
        Unknown_0x80000000  = 0x80000000,           // NOT VERIFIED

        // Masks
        // flags that shouldn't be appended into SMSG_MONSTER_MOVE\SMSG_MONSTER_MOVE_TRANSPORT packet, should be more probably
        Mask_No_Monster_Move = Done, // SKIP
        // Unused, not suported flags
        Mask_Unused         = No_Spline | Frozen | Unknown_0x100 | Unknown_0x20000 | Unknown_0x40000
                            | Unknown_0x800000 | FadeObject | UnlimitedSpeed | Unknown_0x40000000 | Unknown_0x80000000 // SKIP
    };
}
