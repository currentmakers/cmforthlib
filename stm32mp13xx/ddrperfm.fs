\
\ @file ddrperfm.fs
\ @brief DDRPERFM
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DDRPERFM control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant DDRPERFM_DDRPERFM_CTL_START                      \ Start counters which are enabled, the time counter (TCNT) is always enabled. writing a '1â when the counters are running (DDRPERFM_STATUS.BUSY = 1) is ignored
$00000002 constant DDRPERFM_DDRPERFM_CTL_STOP                       \ stop all the counters. Writing a '1â when the counters are stopped (DDRPERFM_STATUS.BUSY = 0) is ignored


\
\ @brief DDRPERFM configurationl register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000000f constant DDRPERFM_DDRPERFM_CFG_EN                         \ enable counter x (from 0 to 3)
$00030000 constant DDRPERFM_DDRPERFM_CFG_SEL                        \ select set of signals to be monitored (from 0 to 3) (see signal set description in ) and counters to be enabled


\
\ @brief DDRPERFM status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000000f constant DDRPERFM_DDRPERFM_STATUS_COVF                    \ Counter x Overflow (with x from 0 to 3)
$00010000 constant DDRPERFM_DDRPERFM_STATUS_BUSY                    \ Busy Status
$80000000 constant DDRPERFM_DDRPERFM_STATUS_TOVF                    \ total counter overflow


\
\ @brief DDRPERFM counter clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant DDRPERFM_DDRPERFM_CCR_CCLR                       \ counter x Clear (with x from 0 to 3)
$80000000 constant DDRPERFM_DDRPERFM_CCR_TCLR                       \ time counter clear


\
\ @brief DDRPERFM interrupt enable register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant DDRPERFM_DDRPERFM_IER_OVFIE                      \ overflow interrupt enable


\
\ @brief DDRPERFM interrupt status register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant DDRPERFM_DDRPERFM_ISR_OVFF                       \ overflow flag This flag is set when one counter is in overflow


\
\ @brief DDRPERFM interrupt clear register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant DDRPERFM_DDRPERFM_ICR_OVF                        \ overflow flag


\
\ @brief DDRPERFM time counter register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant DDRPERFM_DDRPERFM_TCNT_CNT                       \ total time, this is number of DDR controller clocks elapsed while DDRPERFM has been running.


\
\ @brief DDRPERFM event counter 0 register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant DDRPERFM_DDRPERFM_CNT0_CNT                       \ event counter value.


\
\ @brief DDRPERFM event counter 1 register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant DDRPERFM_DDRPERFM_CNT1_CNT                       \ event counter value.


\
\ @brief DDRPERFM event counter 2 register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant DDRPERFM_DDRPERFM_CNT2_CNT                       \ event counter value.


\
\ @brief DDRPERFM event counter 3 register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant DDRPERFM_DDRPERFM_CNT3_CNT                       \ event counter value.


\
\ @brief DDRPERFM hardware configuration register
\ Address offset: 0x3F0
\ Reset value: 0x00000004
\

$0000000f constant DDRPERFM_DDRPERFM_HWCFG_NCNT                     \ number of counters for this configuration (4)


\
\ @brief DDRPERFM version register
\ Address offset: 0x3F4
\ Reset value: 0x00000010
\

$0000000f constant DDRPERFM_DDRPERFM_VER_MINREV                     \ Minor revision number.
$000000f0 constant DDRPERFM_DDRPERFM_VER_MAJREV                     \ Major revision number.


\
\ @brief DDRPERFM ID register
\ Address offset: 0x3F8
\ Reset value: 0x00140061
\

$00000000 constant DDRPERFM_DDRPERFM_ID_ID                          \ DDRPERFM unique identification.


\
\ @brief DDRPERFM magic ID register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant DDRPERFM_DDRPERFM_SID_SID                        \ magic ID for automatic IP discovery.


\
\ @brief DDRPERFM
\
$5a007000 constant DDRPERFM_DDRPERFM_CTL  \ offset: 0x00 : DDRPERFM control register
$5a007004 constant DDRPERFM_DDRPERFM_CFG  \ offset: 0x04 : DDRPERFM configurationl register
$5a007008 constant DDRPERFM_DDRPERFM_STATUS  \ offset: 0x08 : DDRPERFM status register
$5a00700c constant DDRPERFM_DDRPERFM_CCR  \ offset: 0x0C : DDRPERFM counter clear register
$5a007010 constant DDRPERFM_DDRPERFM_IER  \ offset: 0x10 : DDRPERFM interrupt enable register
$5a007014 constant DDRPERFM_DDRPERFM_ISR  \ offset: 0x14 : DDRPERFM interrupt status register
$5a007018 constant DDRPERFM_DDRPERFM_ICR  \ offset: 0x18 : DDRPERFM interrupt clear register
$5a007020 constant DDRPERFM_DDRPERFM_TCNT  \ offset: 0x20 : DDRPERFM time counter register
$5a007030 constant DDRPERFM_DDRPERFM_CNT0  \ offset: 0x30 : DDRPERFM event counter 0 register
$5a007038 constant DDRPERFM_DDRPERFM_CNT1  \ offset: 0x38 : DDRPERFM event counter 1 register
$5a007040 constant DDRPERFM_DDRPERFM_CNT2  \ offset: 0x40 : DDRPERFM event counter 2 register
$5a007048 constant DDRPERFM_DDRPERFM_CNT3  \ offset: 0x48 : DDRPERFM event counter 3 register
$5a0073f0 constant DDRPERFM_DDRPERFM_HWCFG  \ offset: 0x3F0 : DDRPERFM hardware configuration register
$5a0073f4 constant DDRPERFM_DDRPERFM_VER  \ offset: 0x3F4 : DDRPERFM version register
$5a0073f8 constant DDRPERFM_DDRPERFM_ID  \ offset: 0x3F8 : DDRPERFM ID register
$5a0073fc constant DDRPERFM_DDRPERFM_SID  \ offset: 0x3FC : DDRPERFM magic ID register

