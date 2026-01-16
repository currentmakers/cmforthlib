\
\ @file retained.fs
\ @brief RFIP_WAKEUPTIME register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RFIP_WAKEUPTIME register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000000 constant RETAINED_RFIP_WAKEUPTIME_RFIP_WAKEUPTIME         \ (Absolute) Target time to wakeup the RFIP.


\
\ @brief CPU_WAKEUPTIME register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$fffffffe constant RETAINED_CPU_WAKEUPTIME_CPU_WAKEUPTIME           \ (Absolute) Target time to wakeup the CPU.


\
\ @brief WAKEUP_CTRL register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant RETAINED_WAKEUP_CTRL_SOC_WAKEUP_OFFSET           \ Delay to be considered by the Wakeup block to anticipate the wakeup request to the PWRC of the SoC versus the target to wakeup the RFIP (or the CPU).
$40000000 constant RETAINED_WAKEUP_CTRL_CPU_WAKEUP_EN               \ Indicates if the wakeup timer has to wakeup the SoC (match on CPU_WAKEUPTIME[31:4] bit field only) + set the CPU_WAKEUP_F in the WAKEUP_IRQ_STATUS Misc register when match on CPU_WAKEUPTIME[31:0] occurs.
$80000000 constant RETAINED_WAKEUP_CTRL_RFIP_WAKEUP_EN              \ Indicates if the wakeup timer has to wakeup the SoC (match on RFIP_WAKEUPTIME[31:4] bit field only) + trigger an event on the Sequencer and set the RFIP_WAKEUP_F in the WAKEUP_IRQ_STATUS Misc register when match on RFIP_WAKEUPTIME[31:0] occurs.


\
\ @brief RRM_CMDLIST_PTR register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant RETAINED_RRM_CMDLIST_PTR_CMDLIST_PTR_OFFSET      \ Contain the offset versus the SoC RAM base address where to find the RRM-UDRA command list entry point.
$80000000 constant RETAINED_RRM_CMDLIST_PTR_CMDLIST_PTR_VALID       \ Indicate if a command list has to be executed or not


\
\ @brief SEQ_GLOBALTABLE_PTR register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant RETAINED_SEQ_GLOBALTABLE_PTR_SEQ_GLOBALTABLE_PTR    \ Contain the offset versus the SoC RAM base address of the GlobalConfiguration RAM table entry point.


\
\ @brief RFIP_WAKEUPTIME register
\
$49000780 constant RETAINED_RFIP_WAKEUPTIME  \ offset: 0x00 : RFIP_WAKEUPTIME register
$49000784 constant RETAINED_CPU_WAKEUPTIME  \ offset: 0x04 : CPU_WAKEUPTIME register
$49000788 constant RETAINED_WAKEUP_CTRL  \ offset: 0x08 : WAKEUP_CTRL register
$4900078c constant RETAINED_RRM_CMDLIST_PTR  \ offset: 0x0C : RRM_CMDLIST_PTR register
$49000790 constant RETAINED_SEQ_GLOBALTABLE_PTR  \ offset: 0x10 : SEQ_GLOBALTABLE_PTR register

