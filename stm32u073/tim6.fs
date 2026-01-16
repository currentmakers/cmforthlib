\
\ @file tim6.fs
\ @brief TIM6 address block description
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

$00000001 constant TIM6_TIM6_CR1_CEN                                \ Counter enable Note: Gated mode can work only if the CEN bit has been previously set by software. However trigger mode can set the CEN bit automatically by hardware. CEN is cleared automatically in one-pulse mode, when an update event occurs.
$00000002 constant TIM6_TIM6_CR1_UDIS                               \ Update disable This bit is set and cleared by software to enable/disable UEV event generation. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller Buffered registers are then loaded with their preload values.
$00000004 constant TIM6_TIM6_CR1_URS                                \ Update request source This bit is set and cleared by software to select the UEV event sources. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller
$00000008 constant TIM6_TIM6_CR1_OPM                                \ One-pulse mode
$00000080 constant TIM6_TIM6_CR1_ARPE                               \ Auto-reload preload enable
$00000800 constant TIM6_TIM6_CR1_UIFREMAP                           \ UIF status bit remapping


\
\ @brief TIM6 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000070 constant TIM6_TIM6_CR2_MMS                                \ Master mode selection These bits are used to select the information to be sent in master mode to slave timers for synchronization (TRGO). The combination is as follows: When the Counter Enable signal is controlled by the trigger input, there is a delay on TRGO, except if the master/slave mode is selected (see the MSM bit description in the TIMx_SMCR register). Note: The clock of the slave timer or ADC must be enabled prior to receive events from the master timer, and must not be changed on-the-fly while triggers are received from the master timer.


\
\ @brief TIM6 DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM6_TIM6_DIER_UIE                               \ Update interrupt enable
$00000100 constant TIM6_TIM6_DIER_UDE                               \ Update DMA request enable


\
\ @brief TIM6 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM6_TIM6_SR_UIF                                 \ Update interrupt flag This bit is set by hardware on an update event. It is cleared by software. At overflow or underflow regarding the repetition counter value and if UDIS = 0 in the TIMx_CR1 register. When CNT is reinitialized by software using the UG bit in the TIMx_EGR register, if URS1=10 and UDIS1=10 in the TIMx_CR1 register.


\
\ @brief TIM6 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM6_TIM6_EGR_UG                                 \ Update generation This bit can be set by software, it is automatically cleared by hardware.


\
\ @brief TIM6 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM6_TIM6_CNT_CNT                                \ Counter value
$80000000 constant TIM6_TIM6_CNT_UIFCPY                             \ UIF Copy This bit is a read-only copy of the UIF bit of the TIMx_ISR register. If the UIFREMAP bit in TIMx_CR1 is reset, bit 31 is reserved and read as 0.


\
\ @brief TIM6 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM6_TIM6_PSC_PSC                                \ Prescaler value The counter clock frequency CK_CNT is equal to f<sub>CK_PSC</sub> / (PSC[15:0] + 1). PSC contains the value to be loaded into the active prescaler register at each update event. (including when the counter is cleared through UG bit of TIMx_EGR register or through trigger controller when configured in reset mode).


\
\ @brief TIM6 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$0000ffff constant TIM6_TIM6_ARR_ARR                                \ Prescaler value ARR is the value to be loaded into the actual auto-reload register. Refer to Section123.3.1: Time-base unit on page1596 for more details about ARR update and behavior. The counter is blocked while the auto-reload value is null.


\
\ @brief TIM6 address block description
\
$40001000 constant TIM6_TIM6_CR1  \ offset: 0x00 : TIM6 control register 1
$40001004 constant TIM6_TIM6_CR2  \ offset: 0x04 : TIM6 control register 2
$4000100c constant TIM6_TIM6_DIER  \ offset: 0x0C : TIM6 DMA/Interrupt enable register
$40001010 constant TIM6_TIM6_SR   \ offset: 0x10 : TIM6 status register
$40001014 constant TIM6_TIM6_EGR  \ offset: 0x14 : TIM6 event generation register
$40001024 constant TIM6_TIM6_CNT  \ offset: 0x24 : TIM6 counter
$40001028 constant TIM6_TIM6_PSC  \ offset: 0x28 : TIM6 prescaler
$4000102c constant TIM6_TIM6_ARR  \ offset: 0x2C : TIM6 auto-reload register

