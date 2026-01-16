\
\ @file sec_tim6.fs
\ @brief Basic timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM6 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SEC_TIM6_TIM6_CR1_CEN                            \ Counter enable CEN is cleared automatically in one-pulse mode, when an update event occurs.
$00000002 constant SEC_TIM6_TIM6_CR1_UDIS                           \ Update disable This bit is set and cleared by software to enable/disable UEV event generation. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller Buffered registers are then loaded with their preload values.
$00000004 constant SEC_TIM6_TIM6_CR1_URS                            \ Update request source This bit is set and cleared by software to select the UEV event sources. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller
$00000008 constant SEC_TIM6_TIM6_CR1_OPM                            \ One-pulse mode
$00000080 constant SEC_TIM6_TIM6_CR1_ARPE                           \ Auto-reload preload enable
$00000800 constant SEC_TIM6_TIM6_CR1_UIFREMAP                       \ UIF status bit remapping
$00001000 constant SEC_TIM6_TIM6_CR1_DITHEN                         \ Dithering enable Note: The DITHEN bit can only be modified when CEN bit is reset.


\
\ @brief TIM6 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000070 constant SEC_TIM6_TIM6_CR2_MMS                            \ Master mode selection These bits are used to select the information to be sent in master mode to slave timers for synchronization (TRGO). The combination is as follows: Note: The clock of the slave timer or he peripheral receiving the tim_trgo must be enabled prior to receive events from the master timer, and must not be changed on-the-fly while triggers are received from the master timer.


\
\ @brief TIM6 DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant SEC_TIM6_TIM6_DIER_UIE                           \ Update interrupt enable
$00000100 constant SEC_TIM6_TIM6_DIER_UDE                           \ Update DMA request enable


\
\ @brief TIM6 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SEC_TIM6_TIM6_SR_UIF                             \ Update interrupt flag This bit is set by hardware on an update event. It is cleared by software. On counter overflow if UDIS = 0 in the TIMx_CR1 register. When CNT is reinitialized by software using the UG bit in the TIMx_EGR register, if URS = 0 and UDIS = 0 in the TIMx_CR1 register.


\
\ @brief TIM6 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant SEC_TIM6_TIM6_EGR_UG                             \ Update generation This bit can be set by software, it is automatically cleared by hardware.


\
\ @brief TIM6 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant SEC_TIM6_TIM6_CNT_CNT                            \ Counter value Non-dithering mode (DITHEN = 0) The register holds the counter value. Dithering mode (DITHEN = 1) The register only holds the non-dithered part in CNT[15:0]. The fractional part is not available.
$80000000 constant SEC_TIM6_TIM6_CNT_UIFCPY                         \ UIF copy This bit is a read-only copy of the UIF bit of the TIMx_ISR register. If the UIFREMAP bit in TIMx_CR1 is reset, bit 31 is reserved and read as 0.


\
\ @brief TIM6 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant SEC_TIM6_TIM6_PSC_PSC                            \ Prescaler value The counter clock frequency ftim_cnt_ck is equal to ftim_psc_ck / (PSC[15:0] + 1). PSC contains the value to be loaded into the active prescaler register at each update event. (including when the counter is cleared through UG bit of TIMx_EGR register.


\
\ @brief TIM6 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$000fffff constant SEC_TIM6_TIM6_ARR_ARR                            \ Auto-reload value ARR is the value to be loaded into the actual auto-reload register. Refer to for more details about ARR update and behavior. The counter is blocked while the auto-reload value is null. Non-dithering mode (DITHEN = 0) The register holds the auto-reload value in ARR[15:0]. The ARR[19:16] bits are reserved. Dithering mode (DITHEN = 1) The register holds the integer part in ARR[19:4]. The ARR[3:0] bitfield contains the dithered part.


\
\ @brief Basic timers
\
$50001000 constant SEC_TIM6_TIM6_CR1  \ offset: 0x00 : TIM6 control register 1
$50001004 constant SEC_TIM6_TIM6_CR2  \ offset: 0x04 : TIM6 control register 2
$5000100c constant SEC_TIM6_TIM6_DIER  \ offset: 0x0C : TIM6 DMA/Interrupt enable register
$50001010 constant SEC_TIM6_TIM6_SR  \ offset: 0x10 : TIM6 status register
$50001014 constant SEC_TIM6_TIM6_EGR  \ offset: 0x14 : TIM6 event generation register
$50001024 constant SEC_TIM6_TIM6_CNT  \ offset: 0x24 : TIM6 counter
$50001028 constant SEC_TIM6_TIM6_PSC  \ offset: 0x28 : TIM6 prescaler
$5000102c constant SEC_TIM6_TIM6_ARR  \ offset: 0x2C : TIM6 auto-reload register

