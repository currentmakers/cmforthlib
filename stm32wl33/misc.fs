\
\ @file misc.fs
\ @brief RFIP_VERSION register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RFIP_VERSION register
\ Address offset: 0x00
\ Reset value: 0x00001200
\

$000000f0 constant MISC_RFIP_VERSION_REVISION                       \ Revision of the MR_SubG (to be used for metal fixes)
$00000f00 constant MISC_RFIP_VERSION_VERSION                        \ Version of the MR_SubG (to be used for cut upgrades)
$0000f000 constant MISC_RFIP_VERSION_PRODUCT                        \ Used for major upgrades (new protocols support / new features)


\
\ @brief RRM_UDRA_CTRL register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant MISC_RRM_UDRA_CTRL_RRM_CMD_REQ                   \ Action bit: write 1 to request a RRM-UDRA command.


\
\ @brief SEQUENCER_CTRL register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant MISC_SEQUENCER_CTRL_GEN_SEQ_TRIGGER              \ Action bit: write 1 to generate a trigger event on Sequencer.
$00000002 constant MISC_SEQUENCER_CTRL_DISABLE_SEQ                  \ Enable/disable the Sequencer


\
\ @brief ABSOLUTE_TIME register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant MISC_ABSOLUTE_TIME_ABSOLUTE_TIME                 \ Indicate the interpolated absolute.


\
\ @brief SCM_COUNTER_VAL register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00007fff constant MISC_SCM_COUNTER_VAL_SCM_COUNTER_CURRVAL         \ Slow Clock Measurement: number of 16 MHz clock cycles contained in 32 slow clock periods.


\
\ @brief SCM_MIN_MAX register
\ Address offset: 0x14
\ Reset value: 0x00007FFF
\

$00007fff constant MISC_SCM_MIN_MAX_SCM_COUNTER_MINVAL              \ Slow Clock Measurement: minimum SCM_COUNTER value seen since the counter is ON and since last clear request.
$7fff0000 constant MISC_SCM_MIN_MAX_SCM_COUNTER_MAXVAL              \ Slow Clock Measurement: maximum SCM_COUNTER value seen since the counter is ON and since last clear request.
$80000000 constant MISC_SCM_MIN_MAX_CLEAR_MIN_MAX                   \ Write 1' to clear the SCM_COUNTER_MINVAL and SCM_COUNTER_MAXVAL bit fields.


\
\ @brief WAKEUP_IRQ_STATUS register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant MISC_WAKEUP_IRQ_STATUS_CPU_WAKEUP_F              \ Set when the interpolated absolute time matches the CPU_WAKEUPTIME while WAKEUP_CTRL.
$00000002 constant MISC_WAKEUP_IRQ_STATUS_RFIP_WAKEUP_F             \ Set when the interpolated absolute time matches the RFIP_WAKEUPTIME while WAKEUP_CTRL.


\
\ @brief RFIP_VERSION register
\
$49000700 constant MISC_RFIP_VERSION  \ offset: 0x00 : RFIP_VERSION register
$49000704 constant MISC_RRM_UDRA_CTRL  \ offset: 0x04 : RRM_UDRA_CTRL register
$49000708 constant MISC_SEQUENCER_CTRL  \ offset: 0x08 : SEQUENCER_CTRL register
$4900070c constant MISC_ABSOLUTE_TIME  \ offset: 0x0C : ABSOLUTE_TIME register
$49000710 constant MISC_SCM_COUNTER_VAL  \ offset: 0x10 : SCM_COUNTER_VAL register
$49000714 constant MISC_SCM_MIN_MAX  \ offset: 0x14 : SCM_MIN_MAX register
$49000718 constant MISC_WAKEUP_IRQ_STATUS  \ offset: 0x18 : WAKEUP_IRQ_STATUS register

