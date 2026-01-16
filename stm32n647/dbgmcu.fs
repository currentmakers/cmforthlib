\
\ @file dbgmcu.fs
\ @brief Microcontroller debug unit
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DBGMCU identity code register
\ Address offset: 0x00
\ Reset value: 0x00006486
\

$00000fff constant DBGMCU_DBGMCU_IDCODE_DEV_ID                      \ Device ID
$ffff0000 constant DBGMCU_DBGMCU_IDCODE_REV_ID                      \ Revision


\
\ @brief DBGMCU configuration register
\ Address offset: 0x04
\ Reset value: 0x80000000
\

$00000001 constant DBGMCU_DBGMCU_CR_DBG_SLEEP                       \ Allow debug in Sleep mode
$00000002 constant DBGMCU_DBGMCU_CR_DBG_STOP                        \ Allow debug in Stop mode
$00000004 constant DBGMCU_DBGMCU_CR_DBG_STANDBY                     \ Allow debug in Standby mode
$00100000 constant DBGMCU_DBGMCU_CR_DBGCLKEN                        \ Debug clock enable through software
$00200000 constant DBGMCU_DBGMCU_CR_TRACECLKEN                      \ TPIU export clock enable through software
$10000000 constant DBGMCU_DBGMCU_CR_DBTRGOEN                        \ DBTRGIO connection control
$80000000 constant DBGMCU_DBGMCU_CR_HLT_TSGEN_EN                    \ TSGEN halt enable


\
\ @brief DBGMCU APB1L peripheral freeze register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_DBGMCU_APB1LFZ1_DBG_TIM2_STOP             \ TIM2 stop in debug
$00000002 constant DBGMCU_DBGMCU_APB1LFZ1_DBG_TIM3_STOP             \ TIM3 stop in debug
$00000004 constant DBGMCU_DBGMCU_APB1LFZ1_DBG_TIM4_STOP             \ TIM4 stop in debug
$00000008 constant DBGMCU_DBGMCU_APB1LFZ1_DBG_TIM5_STOP             \ TIM5 stop in debug
$00000010 constant DBGMCU_DBGMCU_APB1LFZ1_DBG_TIM6_STOP             \ TIM6 stop in debug
$00000020 constant DBGMCU_DBGMCU_APB1LFZ1_DBG_TIM7_STOP             \ TIM7 stop in debug
$00000040 constant DBGMCU_DBGMCU_APB1LFZ1_DBG_TIM12_STOP            \ TIM12 stop in debug
$00000080 constant DBGMCU_DBGMCU_APB1LFZ1_DBG_TIM13_STOP            \ TIM13 stop in debug
$00000100 constant DBGMCU_DBGMCU_APB1LFZ1_DBG_TIM14_STOP            \ TIM14 stop in debug
$00000200 constant DBGMCU_DBGMCU_APB1LFZ1_DBG_LPTIM1_STOP           \ LPTIM1 stop in debug
$00000800 constant DBGMCU_DBGMCU_APB1LFZ1_DBG_WWDG1_STOP            \ WWDG1 stop in debug
$00001000 constant DBGMCU_DBGMCU_APB1LFZ1_DBG_TIM10_STOP            \ TIM10 stop in debug
$00002000 constant DBGMCU_DBGMCU_APB1LFZ1_DBG_TIM11_STOP            \ TIM11 stop in debug
$00200000 constant DBGMCU_DBGMCU_APB1LFZ1_DBG_I2C1_STOP             \ I2C1 SMBUS timeout stop in debug
$00400000 constant DBGMCU_DBGMCU_APB1LFZ1_DBG_I2C2_STOP             \ I2C2 SMBUS timeout stop in debug
$00800000 constant DBGMCU_DBGMCU_APB1LFZ1_DBG_I2C3_STOP             \ I2C3 SMBUS timeout stop in debug
$01000000 constant DBGMCU_DBGMCU_APB1LFZ1_DBG_I3C1_STOP             \ I3C1 SMBUS timeout stop in debug
$02000000 constant DBGMCU_DBGMCU_APB1LFZ1_DBG_I3C2_STOP             \ I3C2 SMBUS timeout stop in debug


\
\ @brief DBGMCU APB1H peripheral freeze register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000100 constant DBGMCU_DBGMCU_APB1HFZ1_DBG_FDCAN_STOP            \ FDCAN stop in debug


\
\ @brief DBGMCU APB2 peripheral freeze register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_DBGMCU_APB2FZ1_DBG_TIM1_STOP              \ TIM1 stop in debug
$00000002 constant DBGMCU_DBGMCU_APB2FZ1_DBG_TIM8_STOP              \ TIM8 stop in debug
$00008000 constant DBGMCU_DBGMCU_APB2FZ1_DBG_TIM18_STOP             \ TIM18 stop in debug
$00010000 constant DBGMCU_DBGMCU_APB2FZ1_DBG_TIM15_STOP             \ TIM15 stop in debug
$00020000 constant DBGMCU_DBGMCU_APB2FZ1_DBG_TIM16_STOP             \ TIM16 stop in debug
$00040000 constant DBGMCU_DBGMCU_APB2FZ1_DBG_TIM17_STOP             \ TIM17 stop in debug
$00080000 constant DBGMCU_DBGMCU_APB2FZ1_DBG_TIM9_STOP              \ TIM9 stop in debug


\
\ @brief DBGMCU APB4 peripheral freeze register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000100 constant DBGMCU_DBGMCU_APB4FZ1_DBG_I2C4_STOP              \ I2C4 stop in debug
$00000200 constant DBGMCU_DBGMCU_APB4FZ1_DBG_LPTIM2_STOP            \ LPTIM2 stop in debug
$00000400 constant DBGMCU_DBGMCU_APB4FZ1_DBG_LPTIM3_STOP            \ LPTIM3 stop in debug
$00000800 constant DBGMCU_DBGMCU_APB4FZ1_DBG_LPTIM4_STOP            \ LPTIM4 stop in debug
$00001000 constant DBGMCU_DBGMCU_APB4FZ1_DBG_LPTIM5_STOP            \ LPTIM5 stop in debug
$00010000 constant DBGMCU_DBGMCU_APB4FZ1_DBG_RTC_STOP               \ RTC clock is suspended in debug
$00040000 constant DBGMCU_DBGMCU_APB4FZ1_DBG_IWDG_STOP              \ WWDG stop in debug


\
\ @brief DBGMCU APB5 peripheral freeze register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000010 constant DBGMCU_DBGMCU_APB5FZ1_DBG_GFXTIM_STOP            \ GFXTIM stop in debug


\
\ @brief DBGMCU AHB1 peripheral freeze register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_DBGMCU_AHB1FZ1_DBG_GPDMA1_CH0_STOP        \ GPDMA1_CHn suspend in debug
$00000002 constant DBGMCU_DBGMCU_AHB1FZ1_DBG_GPDMA1_CH1_STOP        \ GPDMA1_CHn suspend in debug
$00000004 constant DBGMCU_DBGMCU_AHB1FZ1_DBG_GPDMA1_CH2_STOP        \ GPDMA1_CHn suspend in debug
$00000008 constant DBGMCU_DBGMCU_AHB1FZ1_DBG_GPDMA1_CH3_STOP        \ GPDMA1_CHn suspend in debug
$00000010 constant DBGMCU_DBGMCU_AHB1FZ1_DBG_GPDMA1_CH4_STOP        \ GPDMA1_CHn suspend in debug
$00000020 constant DBGMCU_DBGMCU_AHB1FZ1_DBG_GPDMA1_CH5_STOP        \ GPDMA1_CHn suspend in debug
$00000040 constant DBGMCU_DBGMCU_AHB1FZ1_DBG_GPDMA1_CH6_STOP        \ GPDMA1_CHn suspend in debug
$00000080 constant DBGMCU_DBGMCU_AHB1FZ1_DBG_GPDMA1_CH7_STOP        \ GPDMA1_CHn suspend in debug
$00000100 constant DBGMCU_DBGMCU_AHB1FZ1_DBG_GPDMA1_CH8_STOP        \ GPDMA1_CHn suspend in debug
$00000200 constant DBGMCU_DBGMCU_AHB1FZ1_DBG_GPDMA1_CH9_STOP        \ GPDMA1_CHn suspend in debug
$00000400 constant DBGMCU_DBGMCU_AHB1FZ1_DBG_GPDMA1_CH10_STOP       \ GPDMA1_CHn suspend in debug
$00000800 constant DBGMCU_DBGMCU_AHB1FZ1_DBG_GPDMA1_CH11_STOP       \ GPDMA1_CHn suspend in debug
$00001000 constant DBGMCU_DBGMCU_AHB1FZ1_DBG_GPDMA1_CH12_STOP       \ GPDMA1_CHn suspend in debug
$00002000 constant DBGMCU_DBGMCU_AHB1FZ1_DBG_GPDMA1_CH13_STOP       \ GPDMA1_CHn suspend in debug
$00004000 constant DBGMCU_DBGMCU_AHB1FZ1_DBG_GPDMA1_CH14_STOP       \ GPDMA1_CHn suspend in debug
$00008000 constant DBGMCU_DBGMCU_AHB1FZ1_DBG_GPDMA1_CH15_STOP       \ GPDMA1_CHn suspend in debug


\
\ @brief DBGMCU AHB5 peripheral freeze register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_DBGMCU_AHB5FZ1_DBG_HPDMA1_CH0_STOP        \ HPDMA3_CHn suspend in debug
$00000002 constant DBGMCU_DBGMCU_AHB5FZ1_DBG_HPDMA1_CH1_STOP        \ HPDMA3_CHn suspend in debug
$00000004 constant DBGMCU_DBGMCU_AHB5FZ1_DBG_HPDMA1_CH2_STOP        \ HPDMA3_CHn suspend in debug
$00000008 constant DBGMCU_DBGMCU_AHB5FZ1_DBG_HPDMA1_CH3_STOP        \ HPDMA3_CHn suspend in debug
$00000010 constant DBGMCU_DBGMCU_AHB5FZ1_DBG_HPDMA1_CH4_STOP        \ HPDMA3_CHn suspend in debug
$00000020 constant DBGMCU_DBGMCU_AHB5FZ1_DBG_HPDMA1_CH5_STOP        \ HPDMA3_CHn suspend in debug
$00000040 constant DBGMCU_DBGMCU_AHB5FZ1_DBG_HPDMA1_CH6_STOP        \ HPDMA3_CHn suspend in debug
$00000080 constant DBGMCU_DBGMCU_AHB5FZ1_DBG_HPDMA1_CH7_STOP        \ HPDMA3_CHn suspend in debug
$00000100 constant DBGMCU_DBGMCU_AHB5FZ1_DBG_HPDMA1_CH8_STOP        \ HPDMA3_CHn suspend in debug
$00000200 constant DBGMCU_DBGMCU_AHB5FZ1_DBG_HPDMA1_CH9_STOP        \ HPDMA3_CHn suspend in debug
$00000400 constant DBGMCU_DBGMCU_AHB5FZ1_DBG_HPDMA1_CH10_STOP       \ HPDMA3_CHn suspend in debug
$00000800 constant DBGMCU_DBGMCU_AHB5FZ1_DBG_HPDMA1_CH11_STOP       \ HPDMA3_CHn suspend in debug
$00001000 constant DBGMCU_DBGMCU_AHB5FZ1_DBG_HPDMA1_CH12_STOP       \ HPDMA3_CHn suspend in debug
$00002000 constant DBGMCU_DBGMCU_AHB5FZ1_DBG_HPDMA1_CH13_STOP       \ HPDMA3_CHn suspend in debug
$00004000 constant DBGMCU_DBGMCU_AHB5FZ1_DBG_HPDMA1_CH14_STOP       \ HPDMA3_CHn suspend in debug
$00008000 constant DBGMCU_DBGMCU_AHB5FZ1_DBG_HPDMA1_CH15_STOP       \ HPDMA3_CHn suspend in debug
$00010000 constant DBGMCU_DBGMCU_AHB5FZ1_NPU_DBG_FREEZE             \ NPU stop in debug mode


\
\ @brief DBGMCU status register
\ Address offset: 0xFC
\ Reset value: 0x00010003
\

$00000001 constant DBGMCU_DBGMCU_SR_AP0_PRESENT                     \ Access point 0 presence
$00000002 constant DBGMCU_DBGMCU_SR_AP1_PRESENT                     \ Access point 1 presence
$00010000 constant DBGMCU_DBGMCU_SR_AP0_ENABLE                      \ Access point 0 enable
$00020000 constant DBGMCU_DBGMCU_SR_AP1_ENABLE                      \ Access point 1 enable


\
\ @brief DBGMCU host authentication register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000000 constant DBGMCU_DBGMCU_DBG_AUTH_HOST_MESSAGE              \ Mailbox between debugger and processor


\
\ @brief DBGMCU device authentication register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000000 constant DBGMCU_DBGMCU_DBG_AUTH_DEV_MESSAGE               \ Mailbox between debugger and processor


\
\ @brief DBGMCU message read acknowledge authentication register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_DBGMCU_DBG_AUTH_ACK_HOST_ACK              \ Access status to DBG_AUTH_HOST register
$00000002 constant DBGMCU_DBGMCU_DBG_AUTH_ACK_DEVICE_ACK            \ Access status to DBG_AUTH_DEV register


\
\ @brief Microcontroller debug unit
\
$44001000 constant DBGMCU_DBGMCU_IDCODE  \ offset: 0x00 : DBGMCU identity code register
$44001004 constant DBGMCU_DBGMCU_CR  \ offset: 0x04 : DBGMCU configuration register
$44001010 constant DBGMCU_DBGMCU_APB1LFZ1  \ offset: 0x10 : DBGMCU APB1L peripheral freeze register
$44001014 constant DBGMCU_DBGMCU_APB1HFZ1  \ offset: 0x14 : DBGMCU APB1H peripheral freeze register
$44001018 constant DBGMCU_DBGMCU_APB2FZ1  \ offset: 0x18 : DBGMCU APB2 peripheral freeze register
$4400101c constant DBGMCU_DBGMCU_APB4FZ1  \ offset: 0x1C : DBGMCU APB4 peripheral freeze register
$44001020 constant DBGMCU_DBGMCU_APB5FZ1  \ offset: 0x20 : DBGMCU APB5 peripheral freeze register
$44001024 constant DBGMCU_DBGMCU_AHB1FZ1  \ offset: 0x24 : DBGMCU AHB1 peripheral freeze register
$44001028 constant DBGMCU_DBGMCU_AHB5FZ1  \ offset: 0x28 : DBGMCU AHB5 peripheral freeze register
$440010fc constant DBGMCU_DBGMCU_SR  \ offset: 0xFC : DBGMCU status register
$44001100 constant DBGMCU_DBGMCU_DBG_AUTH_HOST  \ offset: 0x100 : DBGMCU host authentication register
$44001104 constant DBGMCU_DBGMCU_DBG_AUTH_DEV  \ offset: 0x104 : DBGMCU device authentication register
$44001108 constant DBGMCU_DBGMCU_DBG_AUTH_ACK  \ offset: 0x108 : DBGMCU message read acknowledge authentication register

